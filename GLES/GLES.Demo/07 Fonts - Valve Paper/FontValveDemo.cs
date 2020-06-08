using System;
using System.Reflection;
using GLES.Fonts;
using OpenTK.Graphics;

namespace GLES.Demo
{

    /// <summary>
    /// FontDemo
    /// </summary>
    [Demo('7', "Font Valve demo")]
    public class FontValveDemo : DemoBase
    {
        const int TEX_WIDTH = 256;
        const int TEX_HEIGHT = 256;

        int m_FontTexture;

        FontShader m_Shader;

        float m_AlphaTest = 0;

        int m_CoordBuffer;

        enum RenderMode { Glyph, Monochrome, SDFRaw }

        /// <summary>
        /// Constructor
        /// </summary>
        public FontValveDemo()
        {
            m_Shader = new FontShader();
        }

        /// <summary>
        /// Initialise
        /// </summary>
        public override void Initialise()
        {
            base.Initialise();

            m_Shader.Initialise();

            GL.GenTextures(1, out m_FontTexture);
            GL.GenBuffers(1, out m_CoordBuffer);

            //
            // This is important as we the font bitmaps are not 4 byte aligned. We have to tell GL about that.
            //
            GL.PixelStore(PixelStoreParameter.UnpackAlignment, 1);

            // create texture atlas.
            GL.BindTexture(TextureTarget.Texture2D, m_FontTexture);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
                        
            // Bitmap data is just 1 byte. For OpenGL we could use GL_RED. but in ES we use Luminance.
            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Alpha, TEX_WIDTH, TEX_HEIGHT, 0, PixelFormat.Alpha, PixelType.UnsignedByte, IntPtr.Zero);

            // load buffers for displaying a texture.
            LoadBuffers();

            // load a unicode font .
            FreeType.TryLoadFont(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\arialuni.ttf", 250);

            // write some messages.
            LoadFontChars(RenderMode.Glyph,  10, TEX_HEIGHT-10, "A");


        }

        /// <summary>
        /// Load buffers for the textured quad.
        /// </summary>
        private void LoadBuffers()
        {
            int w2 = TEX_WIDTH / 2;
            int h2 = TEX_HEIGHT / 2;
            
            // Load Vertex Buffer.
            float[] coords = new float[] {
                 -w2,  h2,  1,  0, 0,
                  w2,  h2,  1,  1, 0,
                 -w2, -h2,  1,  0, 1,
                  w2, -h2,  1,  1, 1,        
            };

            GL.BindBuffer(BufferTarget.ArrayBuffer, m_CoordBuffer);
            GL.BufferData(BufferTarget.ArrayBuffer, new IntPtr(coords.Length * sizeof(float)), coords, BufferUsage.StaticDraw);

        }

        /// <summary>
        /// Load characters
        /// </summary>
        private void LoadFontChars(RenderMode mode, int x, int y, string msg)
        {
            byte[] texdata = new byte[TEX_WIDTH * TEX_HEIGHT];

            // Loop each character in the message
            foreach (var c in msg)
            {
                // Try and get the data.
                GlyphInfo glyph;
                if (FreeType.TryGetCharBitmap(c, out glyph))
                {

                    // load bitmap data if any available (space doesn't have one of course).
                    if (glyph.BitmapData.Length > 0)
                    {
                        int xst = x + glyph.X;
                        int yst = y - glyph.Y;

                        // copy glyph data.
                        for (int i = 0; i < glyph.Width; i++)
                        {
                            for (int j = 0; j < glyph.Height; j++)
                            {
                                byte pixel = glyph.BitmapData[(j * glyph.Width) + i];

                                // convert to binary.
                                if (mode != RenderMode.Glyph)
                                {
                                    if (pixel > 0x7F)
                                    {
                                        pixel = 0xFF;
                                    }
                                    else if (pixel > 0)
                                    {
                                        pixel = 0x00;
                                    }
                                }

                                // set corresponding texel.
                                texdata[((yst + j) * TEX_WIDTH) + (xst + i)] = pixel;
                            }
                        }
                    }

                    // move on to the next character.
                    x += glyph.AdvanceX;
                    y += glyph.AdvanceY;
                }

                if (mode == RenderMode.SDFRaw)
                {
                    float[,] sdf;
                    SDFHelper.GenerateSDFTexture(texdata, TEX_WIDTH, TEX_HEIGHT, out sdf);

                    texdata = SDFHelper.NormaliseSDFTexture(sdf, TEX_WIDTH, TEX_HEIGHT);
                }

                // Load data up to texture.
                unsafe
                {
                    fixed (byte* p = texdata)
                    {
                        GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Alpha, TEX_WIDTH, TEX_HEIGHT, 0, PixelFormat.Alpha, PixelType.UnsignedByte, (IntPtr)p);
                    }
                }
            }

         


        }

        /// <summary>
        /// Handle key press
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public override bool HandleKeyPress(char key)
        {
            bool handled = true;

            switch (key)
            {
                case 'q':
                    LoadFontChars(RenderMode.Glyph, 10, TEX_HEIGHT - 10, "A");
                    m_AlphaTest = 0f;
                    break;
                case 'w':
                    LoadFontChars(RenderMode.Monochrome, 10, TEX_HEIGHT - 10, "A");
                    m_AlphaTest = 0f;
                    break;
                case 'e':
                    LoadFontChars(RenderMode.SDFRaw, 10, TEX_HEIGHT - 10, "A");
                    m_AlphaTest = 0f;
                    break;
                case 'r':
                    LoadFontChars(RenderMode.SDFRaw, 10, TEX_HEIGHT - 10, "A");
                    m_AlphaTest = 0.5f;
                    break;


                default:
                    handled = false;
                    break;
            }

            return handled;
        }


        /// <summary>
        /// Render
        /// </summary>
        public override void Render()
        {
            // begin using the shader. 
            m_Shader.Begin();

            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.One);

            // update the model and projection matrix
            m_Shader.UpdateProjectionMatrix(m_ProjectionMatrix);
            m_Shader.UpdateModelViewMatrix(m_ModelViewMatrix);
            m_Shader.UpdateAlphaTest(m_AlphaTest);

            // ensure vertex and color attrib arrays are enabled.
            GL.EnableVertexAttribArray(m_Shader.VertexAttribLocation);
            GL.EnableVertexAttribArray(m_Shader.TextureCoordAttribLocation);

            // set up the attribute pointers
            GL.BindBuffer(BufferTarget.ArrayBuffer, m_CoordBuffer);
            GL.VertexAttribPointer(m_Shader.VertexAttribLocation, 3, VertexAttribPointerType.Float, true, 5 * sizeof(float), 0);
            GL.VertexAttribPointer(m_Shader.TextureCoordAttribLocation, 2, VertexAttribPointerType.Float, true, 5 * sizeof(float), 3 * sizeof(float));

            // bind the texture
            GL.BindTexture(TextureTarget.Texture2D, m_FontTexture);

            // draw a quad (made up of two triangles)
            GL.DrawArrays(BeginMode.TriangleStrip, 0, 4);

            GL.Disable(EnableCap.Blend);
            
            // finished with the shader.
            m_Shader.End();

        }

        /// <summary>
        /// Finish
        /// </summary>
        public override void Finish()
        {
            GL.DeleteBuffers(1, ref m_CoordBuffer);
            GL.DeleteTextures(1, ref m_FontTexture);

            // clean up free type.
            FreeType.Finish();
        }

    }
}

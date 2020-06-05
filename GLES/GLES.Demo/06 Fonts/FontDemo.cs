using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using GLES.Fonts;
using OpenTK.Graphics;
using OpenTK.Maths;

namespace GLES.Demo
{

    /// <summary>
    /// FontDemo
    /// </summary>
    [Demo(6, "Font demo")]
    public class FontDemo : IDemo
    {
        int m_FontTexture;

        Matrix4 m_ProjectionMatrix;
        Matrix4 m_ModelViewMatrix;

        TextureShader m_Shader;

        int m_CoordBuffer;

        public FontDemo()
        {
            m_Shader = new TextureShader();

            m_ProjectionMatrix = Matrix4.Identity;
            m_ModelViewMatrix = Matrix4.Identity;
        }

        /// <summary>
        /// Initialise
        /// </summary>
        public void Initialise()
        {
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
            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Luminance, 512, 256, 0, PixelFormat.Luminance, PixelType.UnsignedByte, IntPtr.Zero);

            // load buffers for displaying a texture.
            LoadBuffers();

            // load a unicode font .
            FreeType.TryLoadFont(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\arialuni.ttf", 12);
            
            // write some messages.
            LoadFontChars(10, 50, "Hello there");
            LoadFontChars(10, 75, "This has got some こんにちは unicode characters");
            LoadFontChars(10, 100, "But you have to make sure you use a unicode font set");
            LoadFontChars(10, 125, "We are using arialuni.ttf");


        }

        /// <summary>
        /// Load buffers for the textured quad.
        /// </summary>
        private void LoadBuffers()
        {
            // Load Vertex Buffer.
            float[] coords = new float[] {
                -256,   128,  1,  0, 0,
                -256,  -128,  1,  0, 1,
                 256,   128,  1,  1, 0,
                 256,  -128,  1,  1, 1
            };

            GL.BindBuffer(BufferTarget.ArrayBuffer, m_CoordBuffer);
            GL.BufferData(BufferTarget.ArrayBuffer, new IntPtr(coords.Length * sizeof(float)), coords, BufferUsage.StaticDraw);

        }

        /// <summary>
        /// Load characters
        /// </summary>
        private void LoadFontChars(int x, int y, string msg)
        {
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
                        unsafe
                        {
                            fixed (byte* p = glyph.BitmapData)
                            {
                                // Use text sub image 2D to write this bitmap data into our texture.
                                GL.TexSubImage2D(TextureTarget.Texture2D, 0, x + glyph.X, y - glyph.Y, glyph.Width, glyph.Height, PixelFormat.Luminance, PixelType.UnsignedByte, (IntPtr)p);
                            }
                        }
                    }

                    // move on to the next character.
                    x += glyph.AdvanceX;
                    y += glyph.AdvanceY;
                }
            }

        }


        /// <summary>
        /// OnResize
        /// </summary>
        public void OnResize(int width, int height)
        {
            m_ProjectionMatrix = Matrix4.CreateOrthographic(width, height, -100.0f, 100.0f);
            GL.Viewport(0, 0, width, height);
        }

        /// <summary>
        /// Render
        /// </summary>
        public void Render()
        {
            // begin using the shader. 
            m_Shader.Begin();

            // update the model and projection matrix
            m_Shader.UpdateProjectionMatrix(m_ProjectionMatrix);
            m_Shader.UpdateModelViewMatrix(m_ModelViewMatrix);

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

            // finished with the shader.
            m_Shader.End();

        }

        /// <summary>
        /// Finish
        /// </summary>
        public void Finish()
        {
            GL.DeleteBuffers(1, ref m_CoordBuffer);
            GL.DeleteTextures(1, ref m_FontTexture);

            // clean up free type.
            FreeType.Finish();
        }

    }
}

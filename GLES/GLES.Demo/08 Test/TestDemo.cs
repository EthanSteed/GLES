using System;
using GLES.Demo;
using GLES.Shader;
using System.Reflection;
using OpenTK.Graphics;
using OpenTK.Maths;

namespace Test
{
    /// <summary>
    /// Testing C#.
    /// </summary>
    [Demo('8', "Testing C#")]
    public class TestDemo : DemoBase
    {
        const int FRAME_BUFFER_DIM = 500;
        int m_Width, m_Height;
        //float [] Index;

        CombineShader test_Shader;
        //Buffers
        int m_CombineBuffer, m_IndexBuffer, m_Texture1, m_Texture2;
        int m_Fbo ,m_FboColorTexture, m_FboDepthBuffer;

        ///<summary>
        ///Constructor
        ///</summary>
        public TestDemo()
        {
            test_Shader = new CombineShader();

            m_ProjectionMatrix = Matrix4.Identity;
            m_ModelViewMatrix = Matrix4.Identity;
        }
        ///<summary>
        ///Initialise
        ///</summary>
        public override void Initialise()
        {
            // the color values used when clearing (R,G,B,Trans)
            GL.ClearColor(0.2f, 0.2f, 0.2f, 1f);

            //Basic Shader Initialised
            test_Shader.Initialise();

            //Create Buffers to store data for GPU
            GL.GenFramebuffers(1, out m_Fbo);
            GL.GenTextures(1, out m_FboColorTexture);
            GL.GenRenderbuffers(1, out m_FboDepthBuffer);

            //Frame Buffer function
            InitialiseFBO();

            //position buffer
            GL.GenBuffers(1, out m_CombineBuffer);
            GL.GenBuffers(1, out m_IndexBuffer);

            //Call the function to load the buffers
            LoadBuffers();

            GL.GenTextures(1, out m_Texture1);
            GL.GenTextures(1, out m_Texture2);

            InitAndLoadTexture();
        }
        ///<summary>
        ///Frame Buffer
        ///</summary>
        private void InitialiseFBO()
        {
            // bind to our created frame buffer id for all of the following operations.
            GL.BindFramebuffer(FramebufferTarget.Framebuffer, m_Fbo);
            /*
            // create texture for color image data.
            GL.BindTexture(TextureTarget.Texture2D, m_FboColorTexture);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToEdge);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.ClampToEdge);

            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, FRAME_BUFFER_DIM, FRAME_BUFFER_DIM, 0, PixelFormat.Rgba, PixelType.UnsignedByte, IntPtr.Zero);
            */
            // attach to the frame buffer
            GL.FramebufferTexture2D(FramebufferTarget.Framebuffer, FramebufferSlot.ColorAttachment0, TextureTarget.Texture2D, m_FboColorTexture, 0);

            // create depth buffer
            GL.BindRenderbuffer(RenderbufferTarget.Renderbuffer, m_FboDepthBuffer);
            GL.RenderbufferStorage(RenderbufferTarget.Renderbuffer, RenderbufferInternalFormat.DepthComponent16, FRAME_BUFFER_DIM, FRAME_BUFFER_DIM);
            GL.BindRenderbuffer(RenderbufferTarget.Renderbuffer, 0);

            // attach to the frame buffer.
            GL.FramebufferRenderbuffer(FramebufferTarget.Framebuffer, FramebufferSlot.DepthAttachment, RenderbufferTarget.Renderbuffer, m_FboDepthBuffer);

            // check frame buffer is complete 
            FramebufferErrorCode err = GL.CheckFramebufferStatus(FramebufferTarget.Framebuffer);
            if (err != FramebufferErrorCode.FramebufferComplete)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to create frame buffer : {0}", err));
            }

            // we've finished working with our frame buffer for now.
            GL.BindFramebuffer(FramebufferTarget.Framebuffer, 0);
        }
        ///<summary>
        ///Load Buffers
        ///</summary>
        public void LoadBuffers()
        {
            //Create Buffer
            float[] Buffer = new float[]
            {
               // Coordinates               //Colours           //Textures
               
               // 100.0f,  100.0f, 1.0f,    1.0f, 0.0f, 0.0f,   1, 1,
               // 100.0f, -100.0f, 1.0f,    0.0f, 1.0f, 0.0f,   1, 0,
               //-100.0f,  100.0f, 1.0f,    0.0f, 0.0f, 1.0f,   0, 1,
               //-100.0f, -100.0f, 1.0f,    1.0f, 1.0f, 1.0f,   0, 0,

                100.0f,  100.0f, 1.0f,                        1, 1,
                100.0f, -100.0f, 1.0f,                        1, 0,
               -100.0f,  100.0f, 1.0f,                        0, 1,
               -100.0f, -100.0f, 1.0f,                        0, 0,
                
               /*
                 -100f, -100f, -100f,    1.0f, 0.0f, 0.0f,     0.0f, 0.0f,
                  100f, -100f, -100f,    0.0f, 1.0f, 0.0f,     1.0f, 0.0f,
                  100f,  100f, -100f,    1.0f, 1.0f, 0.0f,     1.0f, 1.0f,
                  100f,  100f, -100f,    1.0f, 1.0f, 0.0f,     1.0f, 1.0f,
                 -100f,  100f, -100f,    0.0f, 1.0f, 1.0f,     0.0f, 1.0f,
                 -100f, -100f, -100f,    1.0f, 0.0f, 0.0f,     0.0f, 0.0f,

                 -100f, -100f,  100f,    1.0f, 0.0f, 0.0f,     0.0f, 0.0f,
                  100f, -100f,  100f,    0.0f, 1.0f, 0.0f,     1.0f, 0.0f,
                  100f,  100f,  100f,    1.0f, 1.0f, 0.0f,     1.0f, 1.0f,
                  100f,  100f,  100f,    1.0f, 1.0f, 0.0f,     1.0f, 1.0f,
                 -100f,  100f,  100f,    0.0f, 1.0f, 1.0f,     0.0f, 1.0f,
                 -100f, -100f,  100f,    1.0f, 0.0f, 0.0f,     0.0f, 0.0f,

                 -100f,  100f,  100f,    1.0f, 0.0f, 0.0f,     1.0f, 0.0f,
                 -100f,  100f, -100f,    0.0f, 1.0f, 0.0f,     1.0f, 1.0f,
                 -100f, -100f, -100f,    1.0f, 1.0f, 0.0f,     0.0f, 1.0f,
                 -100f, -100f, -100f,    1.0f, 1.0f, 0.0f,     0.0f, 1.0f,
                 -100f, -100f,  100f,    0.0f, 1.0f, 1.0f,     0.0f, 0.0f,
                 -100f,  100f,  100f,    1.0f, 0.0f, 0.0f,     1.0f, 0.0f,

                  100f,  100f,  100f,    1.0f, 0.0f, 0.0f,     1.0f, 0.0f,
                  100f,  100f, -100f,    0.0f, 1.0f, 0.0f,     1.0f, 1.0f,
                  100f, -100f, -100f,    1.0f, 1.0f, 0.0f,     0.0f, 1.0f,
                  100f, -100f, -100f,    1.0f, 1.0f, 0.0f,     0.0f, 1.0f,
                  100f, -100f,  100f,    0.0f, 1.0f, 1.0f,     0.0f, 0.0f,
                  100f,  100f,  100f,    1.0f, 0.0f, 0.0f,     1.0f, 0.0f,

                 -100f, -100f, -100f,    1.0f, 0.0f, 0.0f,     0.0f, 1.0f,
                  100f, -100f, -100f,    0.0f, 1.0f, 0.0f,     1.0f, 1.0f,
                  100f, -100f,  100f,    1.0f, 1.0f, 0.0f,     1.0f, 0.0f,
                  100f, -100f,  100f,    1.0f, 1.0f, 0.0f,     1.0f, 0.0f,
                 -100f, -100f,  100f,    0.0f, 1.0f, 1.0f,     0.0f, 0.0f,
                 -100f, -100f, -100f,    1.0f, 0.0f, 0.0f,     0.0f, 1.0f,

                 -100f,  100f, -100f,    1.0f, 0.0f, 0.0f,     0.0f, 1.0f,
                  100f,  100f, -100f,    0.0f, 1.0f, 0.0f,     1.0f, 1.0f,
                  100f,  100f,  100f,    1.0f, 1.0f, 0.0f,     1.0f, 0.0f,
                  100f,  100f,  100f,    1.0f, 1.0f, 0.0f,     1.0f, 0.0f,
                 -100f,  100f,  100f,    0.0f, 1.0f, 1.0f,     0.0f, 0.0f,
                 -100f,  100f, -100f,    1.0f, 0.0f, 0.0f,     0.0f, 1.0f,
                */
                /*
                         -100f,  100f,  100f,  0, 0,
                          100f,  100f,  100f,  1, 0,
                         -100f, -100f,  100f,  0, 1,
                          100f, -100f,  100f,  1, 1,
                          100f, -100f, -100f,  1, 0,
                          100f,  100f,  100f,  0, 1,
                          100f,  100f, -100f,  0, 0,
                         -100f,  100f,  100f,  1, 1,
                         -100f,  100f, -100f,  1, 0,
                         -100f, -100f,  100f,  0, 1,
                         -100f, -100f, -100f,  0, 0,
                          100f, -100f, -100f,  1, 0,
                         -100f,  100f, -100f,  0, 1,
                          100f,  100f, -100f,  1, 1,
                */
            };

            //bind the buffer
            GL.BindBuffer(BufferTarget.ArrayBuffer, m_CombineBuffer);
            GL.BufferData(BufferTarget.ArrayBuffer, new IntPtr(sizeof(float) * Buffer.Length), Buffer, BufferUsage.StaticDraw);

            /*
            Index = new float[]
            {
                0, 1, 2,
                1, 2, 3,
            };

            //bind the Index
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, m_IndexBuffer);
            GL.BufferData(BufferTarget.ElementArrayBuffer, new IntPtr(sizeof(float) * Index.Length), Index, BufferUsage.StaticDraw);
            */

        }
        ///<summary>
        ///Window Resize
        ///</summary>
        public override void OnResize(int width, int height)
        {
            m_Width = width;
            m_Height = height;
            // this sets up GL units to use for the display. We simply set the GL units 
            // to match the pixel units of the current window. Create Ortho sets the coordinate
            // system to +/- width/2 and +/- height/2  so 0,0 will be in the center of the window
            // -width/2, -height/2 will be in the bottom left.
            m_ProjectionMatrix = Matrix4.CreateOrthographic(width, height, -100.0f, 100.0f);

            // Viewport says what part of the window are we going to render to. We will
            // just set this to the window size width. You could choose to just render to 
            // a small square on the window if you wanted to. What ever size of viewport you choose
            // the ortho coordinate system will still be the same as above. Best thing to do
            // is to experiment changing the viewport width / height to see the effects.
            GL.Viewport(0, 0, width, height);
        }
        ///<summary>
        ///Handle key press
        ///</summary>
        public override bool HandleKeyPress(char key)
        {
            return false;
        }
        /// <summary>
        /// Bind Textures to buffers and load them.
        /// </summary>
        private void InitAndLoadTexture()
        {
            // tell the graphics card what texture we are working with.
            GL.BindTexture(TextureTarget.Texture2D, m_Texture1);

            // set filtering and wrapping options.
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToEdge);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.ClampToEdge);

            // load the image data into the texture target.
            byte[] imgdata1;
            GLES.EmbeddedResourceHelper.GetEmbeddedFileAsBytes(Assembly.GetExecutingAssembly(), "container.jpg", out imgdata1);

            unsafe
            {
                fixed (byte* p1 = imgdata1)
                {
                    GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgb, 256, 256, 0, PixelFormat.Rgb, PixelType.UnsignedByte, (IntPtr)p1);
                }
            }
            // tell the graphics card what texture we are working with.
            GL.BindTexture(TextureTarget.Texture2D, m_Texture2);

            // set filtering and wrapping options.
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToEdge);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.ClampToEdge);

            // load the image data into the texture target.
            byte[] imgdata2;
            GLES.EmbeddedResourceHelper.GetEmbeddedFileAsBytes(Assembly.GetExecutingAssembly(), "awesomeface.png", out imgdata2);

            unsafe
            {
                fixed (byte* p2 = imgdata2)
                {
                    GL.TexImage2D(TextureTarget.Texture2D, 3, PixelInternalFormat.Rgb, 256, 256, 0, PixelFormat.Rgb, PixelType.UnsignedByte, (IntPtr)p2);
                }
            }
        }

        ///<summary>
        ///Render
        ///</summary>
        float angle = 0;
        public override void Render()
        {
            //Framebuffer
            GL.BindFramebuffer(FramebufferTarget.Framebuffer, m_Fbo);
            GL.Enable(EnableCap.DepthTest);
            
            GL.ClearColor(0.3f, 0.3f, 0.3f, 1f);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            //resize window
            OnResize(m_Width, m_Height);

            test_Shader.Begin();
            //reset the model view matrix
            m_ModelViewMatrix = Matrix4.Identity;

            test_Shader.UpdateProjectionMatrix(m_ProjectionMatrix);
            test_Shader.UpdateModelViewMatrix(m_ModelViewMatrix);

            //ensure Vertex, color, Texture attrib
            GL.EnableVertexAttribArray(test_Shader.VertexAttribLocation);
            //GL.EnableVertexAttribArray(test_Shader.ColorAttribLocation);
            GL.EnableVertexAttribArray(test_Shader.TextureCoordAttribLocation);

            //Find Data
            GL.BindBuffer(BufferTarget.ArrayBuffer, m_CombineBuffer);
            GL.VertexAttribPointer(test_Shader.VertexAttribLocation, 3, VertexAttribPointerType.Float, true, sizeof(float) * 5, 0);
            //GL.VertexAttribPointer(test_Shader.ColorAttribLocation, 3, VertexAttribPointerType.Float, true, sizeof(float) * 8, sizeof(float) * 3);
            GL.VertexAttribPointer(test_Shader.TextureCoordAttribLocation, 2, VertexAttribPointerType.Float, true, sizeof(float) * 5, sizeof(float) * 6);

            //test_Shader.SetTextureSlot(0);
            //GL.ActiveTexture(TextureUnit.Texture0);
            //GL.BindTexture(TextureTarget.Texture2D, m_Texture2);

            //test_Shader.SetTextureSlot(3);
            //GL.ActiveTexture(TextureUnit.Texture3);
            //GL.BindTexture(TextureTarget.Texture2D, m_Texture1);

            GL.DrawArrays(BeginMode.TriangleStrip, 0, 36);

            //GL.BindTexture(TextureTarget.Texture2D, 0);
            
            //draw
            //GL.BindBuffer(BufferTarget.ElementArrayBuffer, m_IndexBuffer);
            //GL.DrawElements(BeginMode.Triangles, Index.Length, DrawElementsType.UnsignedShort, IntPtr.Zero);
            //GL.DrawElements(PrimitiveType.Triangles, Index.Length, DrawElementsType.UnsignedInt, 0);

            test_Shader.End();


            angle += 1;
            if (angle > 360)
            {
                angle = 0f;
            };
        }
        ///<summary>
        ///Finsh
        ///</summary>
        public override void Finish()
        {
            test_Shader.Finish();

            GL.DeleteBuffers(1, ref m_CombineBuffer);
        }
    }
}

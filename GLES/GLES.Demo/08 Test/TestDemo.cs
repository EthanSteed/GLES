using System;
using GLES.Demo;
using GLES.Shader;
using OpenTK.Graphics;
using OpenTK.Maths;

namespace Test
{
    /// <summary>
    /// Testing C#.
    /// </summary>
    [Demo('8', "Testing C#")]
    public class TestDemo : IDemo
    {
        Matrix4 m_ProjectionMatrix;
        Matrix4 m_ModelViewMatrix;

        const int FRAME_BUFFER_DIM = 500;

        int m_Fbo;
        int m_FboColorTexture;
        int m_FboDepthBuffer;

        //set up shader
        BasicShader m_Shader;

        // buffers
        int m_VertexBuffer;
        int m_ColorBuffer;

        /// <summary>
        /// Constructor
        /// </summary>
        public TestDemo()
        {
            m_Shader = new BasicShader();

            m_ProjectionMatrix = Matrix4.Identity;
            m_ModelViewMatrix = Matrix4.Identity;
        }
        /// <summary>
        /// Initialise
        /// </summary>
        public void Initialise()
        {
            // Set the clear color
            GL.ClearColor(0.2f, 0.2f, 0.2f, 1f);

            // Initialise the basic shader.
            m_Shader.Initialise();

            // create a frame buffer object.
            GL.GenFramebuffers(1, out m_Fbo);
            GL.GenTextures(1, out m_FboColorTexture);
            GL.GenRenderbuffers(1, out m_FboDepthBuffer);

            //create FBO
            InitialiseFBO();

            // generate buffers for triangle data.
            //GL.GenBuffers(1, out m_VertexBuffer);
            GL.GenBuffers(1, out m_ColorBuffer);

            // load some data into these buffers.
            LoadBuffers();
        }
        /// <summary>
        /// intialise FBO
        /// </summary>
        private void InitialiseFBO()
        {
            // bind to our created frame buffer id for all of the following operations.
            GL.BindFramebuffer(FramebufferTarget.Framebuffer, m_Fbo);

            // create texture for color image data.
            GL.BindTexture(TextureTarget.Texture2D, m_FboColorTexture);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToEdge);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.ClampToEdge);

            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, FRAME_BUFFER_DIM, FRAME_BUFFER_DIM, 0, PixelFormat.Rgba, PixelType.UnsignedByte, IntPtr.Zero);

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
        /// <summary>
        /// Load up the buffers with data.
        /// </summary>
        private void LoadBuffers()
        {
            // Load Vertex Buffer.
            Vector3[] verts = new Vector3[] {
                new Vector3( -100, -100,   0), //base bottom left
                new Vector3(    0,  100,   0), //base top
                new Vector3(  100, -100,   0), //base bottom right
                
                new Vector3(    0,    0, 100), //top
                new Vector3( -100, -100,   0), //base bottom left 
                new Vector3(    0,  100,   0), //base top

                new Vector3(    0,    0, 100), //top
                new Vector3(  100, -100,   0), //base bottom right
                new Vector3(    0,  100,   0), //base top

                new Vector3(    0,    0, 100), //top
                new Vector3( -100, -100,   0), //base bottom left 
                new Vector3(  100, -100,   0), //base bottom right

            };

            GL.BindBuffer(BufferTarget.ArrayBuffer, m_VertexBuffer);
            GL.BufferData(BufferTarget.ArrayBuffer, new IntPtr(verts.Length * Vector3.SizeInBytes), verts, BufferUsage.StaticDraw);

            // Load Color Buffer.
            Vector4[] colors = new Vector4[]
            {
                new Vector4(1,1,1,1),
                new Vector4(1,1,1,1),
                new Vector4(1,1,1,1)
            };

            GL.BindBuffer(BufferTarget.ArrayBuffer, m_ColorBuffer);
            GL.BufferData(BufferTarget.ArrayBuffer, new IntPtr(colors.Length * Vector4.SizeInBytes), colors, BufferUsage.StaticDraw);
        }

        /// <summary>
        /// Window has resized
        /// </summary>
        public void OnResize(int width, int height)
        {
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

        /// <summary>
        /// Handle key press. (Not used)
        /// </summary>
        /// <param name="key"></param>
        public bool HandleKeyPress(char key)
        {
            return false;
        }


        float angle = 0;

        /// <summary>
        /// Render
        /// </summary>
        public void Render()
        {

            // bind to our frame buffer
            GL.BindFramebuffer(FramebufferTarget.Framebuffer, m_Fbo);
            GL.Enable(EnableCap.DepthTest);

            // we need to clear our frame buffer ourselves.
            GL.ClearColor(0.0f, 0.0f, 0.0f, 1f);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);


            // back to the standard frame buffer.
            GL.BindFramebuffer(FramebufferTarget.Framebuffer, 0);
            GL.ClearColor(0.2f, 0.2f, 0.2f, 1f);

            // begin using the shader. 
            m_Shader.Begin();

            // reset the model view matrix.
            m_ModelViewMatrix = Matrix4.Identity;

            // apply a rotation to the model view.
            m_ModelViewMatrix = Matrix4.Mult(m_ModelViewMatrix, Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(angle)));
            m_ModelViewMatrix = Matrix4.Mult(m_ModelViewMatrix, Matrix4.CreateRotationX(MathHelper.DegreesToRadians(angle)));

            // update the model and projection matrix
            m_Shader.UpdateProjectionMatrix(m_ProjectionMatrix);
            m_Shader.UpdateModelViewMatrix(m_ModelViewMatrix);

            // bind to our buffers and tell the shader where to look for the data.

            // first the vertices

            // ensure vertex and color attrib arrays are enabled.
            GL.EnableVertexAttribArray(m_Shader.VertexAttribLocation);

            GL.BindBuffer(BufferTarget.ArrayBuffer, m_VertexBuffer);
            GL.VertexAttribPointer(m_Shader.VertexAttribLocation, 3, VertexAttribPointerType.Float, true, Vector3.SizeInBytes, 0);

            // now the colours
            GL.EnableVertexAttribArray(m_Shader.ColorAttribLocation);

            GL.BindBuffer(BufferTarget.ArrayBuffer, m_ColorBuffer);
            GL.VertexAttribPointer(m_Shader.ColorAttribLocation, 4, VertexAttribPointerType.Float, true, Vector4.SizeInBytes, 0);

            // then draw. We only have 3 vertices making up 1 triangle
            GL.DrawArrays(BeginMode.Triangles, 0, 12);
            
            // finished with the shader.
            m_Shader.End();

            // increment our rotation
            angle += 1;
            if (angle > 360)
            {
                angle = 0f;
            };
        }

        /// <summary>
        /// Finish
        /// </summary>
        public void Finish()
        {
            // finished with the shader
            m_Shader.Finish();

            // free up the buffers.
            GL.DeleteBuffers(1, ref m_VertexBuffer);
            GL.DeleteBuffers(1, ref m_ColorBuffer);

        }
    }
}
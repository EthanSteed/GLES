using System;
using System.Reflection;
using GLES.Shader;
using OpenTK.Graphics;
using OpenTK.Maths;

namespace GLES.Demo
{
    [Demo(5, "Frame Buffer")]
    public class FrameBufferDemo : IDemo
    {
        int m_Width, m_Height;

        Matrix4 m_ProjectionMatrix;
        Matrix4 m_ModelViewMatrix;

        TriangleDemo m_TriangleDemo ;

        TextureShader m_Shader;
        int m_CubBuffer;


        int m_Fbo;
        int m_FboColorTexture;
        int m_FboDepthBuffer;


        /// <summary>
        /// Constructor
        /// </summary>
        public FrameBufferDemo()
        {
            m_TriangleDemo = new TriangleDemo();

            m_Shader = new TextureShader();

            m_ProjectionMatrix = Matrix4.Identity;
            m_ModelViewMatrix = Matrix4.Identity;
        }

        /// <summary>
        /// Initialise
        /// </summary>
        public void Initialise()
        {
            m_TriangleDemo.Initialise();

            m_Shader.Initialise();

            // create a frame buffer object.
            GL.GenFramebuffers(1, out m_Fbo);
            GL.GenTextures(1, out m_FboColorTexture);
            GL.GenRenderbuffers(1, out m_FboDepthBuffer);

            // create FBO
            InitialiseFBO();

            // create buffers for displaying cube.
            GL.GenBuffers(1, out m_CubBuffer);

            // Load buffers for display FBO texture
            LoadBuffers();
        }

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
            
            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, 256, 256, 0, PixelFormat.Rgba, PixelType.UnsignedByte, IntPtr.Zero);

            // attach to the frame buffer
            GL.FramebufferTexture2D(FramebufferTarget.Framebuffer, FramebufferSlot.ColorAttachment0, TextureTarget.Texture2D, m_FboColorTexture, 0);

            // create depth buffer
            GL.BindRenderbuffer(RenderbufferTarget.Renderbuffer, m_FboDepthBuffer);
            GL.RenderbufferStorage(RenderbufferTarget.Renderbuffer, RenderbufferInternalFormat.DepthComponent16, 256, 256);
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
        /// Load up the buffers for rendering our framebuffer texture data.
        /// </summary>
        private void LoadBuffers()
        {
            // verts and tex coords for a triangle strip cube
            float[] vertsandtc = new float[]{
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
            };

            GL.BindBuffer(BufferTarget.ArrayBuffer, m_CubBuffer);
            GL.BufferData(BufferTarget.ArrayBuffer, new IntPtr(sizeof(float) * vertsandtc.Length), vertsandtc, BufferUsage.StaticDraw);
        }

        /// <summary>
        /// Window has resized
        /// </summary>
        public void OnResize(int width, int height)
        {
            m_Width = width;
            m_Height = height;

            // this sets up GL units to use for the display. We simply set the GL units 
            // to match the pixel units of the current window. Create Ortho sets the coordinate
            // system to +/- width/2 and +/- height/2  so 0,0 will be in the center of the window
            // -width/2, -height/2 will be in the bottom left.
            m_ProjectionMatrix = Matrix4.CreateOrthographic(width, height, -1000.0f, 1000.0f);

            // Viewport says what part of the window are we going to render to. We will
            // just set this to the window size width. You could choose to just render to 
            // a small square on the window if you wanted to. What ever size of viewport you choose
            // the ortho coordinate system will still be the same as above. Best thing to do
            // is to experiment changing the viewport width / height to see the effects.
            GL.Viewport(0, 0, width, height);
        }

        float angle = 0;

        /// <summary>
        /// Render
        /// </summary>
        public void Render()
        {
            // 
            // First Render to our frame buffer.
            //

            // bind to our frame buffer
            GL.BindFramebuffer(FramebufferTarget.Framebuffer, m_Fbo);
            GL.Enable(EnableCap.DepthTest);
 
            // we need to clear our frame buffer ourselves.
            GL.ClearColor(0.0f, 0.0f, 0.0f, 1f);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            // render the triangle from the triangle demo onto our frame buffer.
            m_TriangleDemo.OnResize(256, 256);
            m_TriangleDemo.Render();

            //
            // Now render the frame buffer texture to our screen.
            //

            // back to the standard frame buffer.
            GL.BindFramebuffer(FramebufferTarget.Framebuffer, 0);
            GL.ClearColor(0.2f, 0.2f, 0.2f, 1f);

            // ensure viewport set correctly.
            OnResize(m_Width, m_Height);

            // begin using the shader. 
            m_Shader.Begin();
            
            // reset the model view matrix.
            m_ModelViewMatrix = Matrix4.Identity;

            // apply a rotation to the model view.
            m_ModelViewMatrix = Matrix4.Mult(m_ModelViewMatrix, Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(angle)));
            m_ModelViewMatrix = Matrix4.Mult(m_ModelViewMatrix, Matrix4.CreateRotationY(MathHelper.DegreesToRadians(angle)));

            m_Shader.UpdateProjectionMatrix(m_ProjectionMatrix);
            m_Shader.UpdateModelViewMatrix(m_ModelViewMatrix);

            // ensure vertex and tex coords attrib arrays are enabled.
            GL.EnableVertexAttribArray(m_Shader.VertexAttribLocation);
            GL.EnableVertexAttribArray(m_Shader.TextureCoordAttribLocation);

            // set up where to find the data in the buffer.
            GL.BindBuffer(BufferTarget.ArrayBuffer, m_CubBuffer);
            GL.VertexAttribPointer(m_Shader.VertexAttribLocation, 3, VertexAttribPointerType.Float, true, sizeof(float) * 5, 0);
            GL.VertexAttribPointer(m_Shader.TextureCoordAttribLocation, 2, VertexAttribPointerType.Float, true, sizeof(float) * 5, sizeof(float) * 3);

            // set up to look at the Frame buffer texture.
            m_Shader.SetTextureSlot(0);
            GL.ActiveTexture(TextureUnit.Texture0);
            GL.BindTexture(TextureTarget.Texture2D, m_FboColorTexture);

            // draw the cube (made up of triangle strip)
            GL.DrawArrays(BeginMode.TriangleStrip, 0, 14);
          
            GL.BindTexture(TextureTarget.Texture2D, 0);

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
            m_TriangleDemo.Finish();

            // finished with the shader
            m_Shader.Finish();

            // clean up buffers.
            GL.DeleteFramebuffers(1, ref m_Fbo);
            GL.DeleteTextures(1, ref m_FboColorTexture);
            GL.DeleteRenderbuffers(1 , ref m_FboDepthBuffer);

            GL.DeleteBuffers(1, ref m_CubBuffer);
  

        }

    }
}

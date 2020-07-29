using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows;
using System.Xml.Schema;
//using System.Windows.Input;
//using System.Windows.Forms;
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
    public class TestDemo : DemoBase
    {
        int m_Width, m_Height;
        float [] Index;
        float[] cubePositions;
        int BufferLen;
        const int FRAME_BUFFER_DIM = 500;
        const float MOVE_SPEED = 0.5f;
        float FOV = (float)(Math.PI / 2);

        float MouseX, MouseY;

        //MouseEventArgs MouseInterrupt;
        MouseEventHandler MouseHandle;

        Vector3 cameraPos = Vector3.Zero;
        Vector3 cameraFront = Vector3.Zero; 
        Vector3 cameraUp = Vector3.Zero; 

        BasicShaderView test_Shader;

        

        //Buffers
        int m_CombineBuffer, m_IndexBuffer;

        int m_Fbo;
        //int m_FboColorTexture;
        int m_FboDepthBuffer;
        ///<summary>
        ///Constructor
        ///</summary>
        public TestDemo()
        {
            test_Shader = new BasicShaderView();

            m_ProjectionMatrix = Matrix4.Identity;
            m_ModelViewMatrix = Matrix4.Identity;
            m_ViewMatrix = Matrix4.Identity;

            cameraPos.Z = 3.0f;
            cameraFront.Z = -1.0f;
            cameraUp.Y = 1.0f;
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

            //FBO Depth
            GL.GenFramebuffers(1, out m_Fbo);
            //GL.GenTextures(1, out m_FboColorTexture);
            GL.GenRenderbuffers(1, out m_FboDepthBuffer);

            // create FBO
            InitialiseFBO();

            //Create Buffers to store data for GPU
            GL.GenBuffers(1, out m_CombineBuffer);
            GL.GenBuffers(1, out m_IndexBuffer);

            //Call the function to load the buffers
            LoadBuffers();
        }

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

            // attach to the frame buffer
            GL.FramebufferTexture2D(FramebufferTarget.Framebuffer, FramebufferSlot.ColorAttachment0, TextureTarget.Texture2D, m_FboColorTexture, 0);
            */

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
                  //Coordinates      //Colours           
                  1f,  1f,  1f,      1.0f, 1.0f, 1.0f,
                  1f, -1f,  1f,      1.0f, 1.0f, 0.0f,
                 -1f,  1f,  1f,      1.0f, 0.0f, 1.0f,
                 -1f, -1f,  1f,      0.0f, 1.0f, 1.0f,

                 -1f, -1f, -1f,      1.0f, 1.0f, 1.0f,
                  1f, -1f,  1f,      1.0f, 1.0f, 0.0f,
                  1f, -1f, -1f,      1.0f, 1.0f, 0.0f,
                  1f,  1f,  1f,      1.0f, 1.0f, 1.0f,

                  1f,  1f, -1f,      1.0f, 1.0f, 1.0f,
                 -1f,  1f,  1f,      1.0f, 0.0f, 1.0f,
                 -1f,  1f, -1f,      1.0f, 0.0f, 1.0f,
                 -1f, -1f, -1f,      1.0f, 0.0f, 1.0f,
                    
                  1f,  1f, -1f,      1.0f, 1.0f, 0.0f,
                  1f, -1f, -1f,      0.0f, 0.0f, 1.0f,
            };

            BufferLen = Buffer.Length / 6;

            //bind the buffer
            GL.BindBuffer(BufferTarget.ArrayBuffer, m_CombineBuffer);
            GL.BufferData(BufferTarget.ArrayBuffer, new IntPtr(sizeof(float) * Buffer.Length), Buffer, BufferUsage.StaticDraw);

            Index = new float[]
            {
                0, 1, 2,
                1, 2, 3,
            };

            //bind the Index
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, m_IndexBuffer);
            GL.BufferData(BufferTarget.ElementArrayBuffer, new IntPtr(sizeof(float) * Index.Length), Index, BufferUsage.StaticDraw);

            cubePositions = new float[] 
                {
                  00.0f,  00.0f,  00.0f,
                  05.0f,  12.0f, -03.0f,
                 -02.5f, -05.2f, -05.5f,
                 -07.8f, -05.0f, -03.3f,
                  05.4f, -00.4f, -07.5f,
                 -02.7f,  07.0f, -22.5f,
                  02.3f, -05.0f, -05.5f,
                  02.5f,  05.0f, -05.5f,
                  02.5f,  00.2f, -02.5f,
                 -02.3f,  02.0f, -02.5f
                };

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
            //m_ProjectionMatrix = Matrix4.CreateOrthographic(width, height, -1000.0f, 1000.0f);

            m_ProjectionMatrix = Matrix4.CreatePerspectiveFieldOfView(FOV, (width/height), 0.01f, 10000.0f);

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
            bool handled = true;

            switch (key)
            {
                case 'w':
                    cameraPos += MOVE_SPEED * cameraFront;
                    break;
                case 's':
                    cameraPos -= MOVE_SPEED * cameraFront;
                    break;
                case 'a':
                    cameraPos -= Vector3.Normalize(Vector3.Cross(cameraFront, cameraUp)) * MOVE_SPEED;
                    break;
                case 'd':
                    cameraPos += Vector3.Normalize(Vector3.Cross(cameraFront, cameraUp)) * MOVE_SPEED;
                    break;
                case '':
                    Finish();
                    break;
                default:
                        handled = false;
                        break;
            }

            return (handled);
        }
        /// <summary>
        /// Allow demo to handle Mouse movement.
        /// </summary>
        public override bool HandleMouseMove(double Xpos, double Ypos)
        {

            return true;
        }

        /// <summary>
        /// Allow Demo to Handle Mouse Wheel
        ///</summary>
        public override bool HandleMouseWheel(int Delta)
        {
            FOV -= (float)Delta/1000;
            if (FOV < 1.0f)
                FOV = 1.0f;
            if (FOV > Math.PI - 0.5f)
                FOV = (float)Math.PI - 0.5f;
            return true;
        }
        Vector3 Move;

        ///<summary>
        ///Render
        ///</summary>
        float angle = 0;
        public override void Render()
        {
            
            // bind to our frame buffer
            //GL.BindFramebuffer(FramebufferTarget.Framebuffer, m_Fbo);
            GL.BindFramebuffer(FramebufferTarget.Framebuffer, 0);
            GL.Enable(EnableCap.DepthTest);
            GL.ClearColor(0.2f, 0.2f, 0.2f, 1f);
            GL.Clear(ClearBufferMask.DepthBufferBit);

            //resize window
            OnResize(m_Width, m_Height);

            test_Shader.Begin();
            //reset the model view matrix

            //Loop for multi object
            for (int i = 0; i < 10; i++)
            {
            //int i = 1;
                Move.X = cubePositions[3 * i];
                Move.Y = cubePositions[3 * i + 1];
                Move.Z = cubePositions[3 * i + 2];

                m_ModelViewMatrix = Matrix4.CreateTranslation(Move);
                m_ModelViewMatrix = Matrix4.Mult(m_ModelViewMatrix, Matrix4.CreateRotationX(i + angle/100));
                m_ModelViewMatrix = Matrix4.Mult(m_ModelViewMatrix, Matrix4.CreateRotationY(i + angle/100));
                m_ModelViewMatrix = Matrix4.Mult(m_ModelViewMatrix, Matrix4.CreateRotationZ(i + angle/100));

                m_ViewMatrix = Matrix4.LookAt(cameraPos, cameraPos + cameraFront, cameraUp);

                test_Shader.UpdateProjectionMatrix(m_ProjectionMatrix);
                test_Shader.UpdateModelViewMatrix(m_ModelViewMatrix);
                test_Shader.UpdateViewMatrix(m_ViewMatrix);

                //ensure Vertex, color, Texture attrib
                GL.EnableVertexAttribArray(test_Shader.VertexAttribLocation);
                GL.EnableVertexAttribArray(test_Shader.ColorAttribLocation);
                //GL.EnableVertexAttribArray(test_Shader.TextureCoordAttribLocation);

                //Find Data
                GL.BindBuffer(BufferTarget.ArrayBuffer, m_CombineBuffer);
                GL.VertexAttribPointer(test_Shader.VertexAttribLocation, 3, VertexAttribPointerType.Float, true, sizeof(float) * 6, 0);
                GL.VertexAttribPointer(test_Shader.ColorAttribLocation, 3, VertexAttribPointerType.Float, true, sizeof(float) * 6, sizeof(float) * 3);
                //GL.VertexAttribPointer(test_Shader.TextureCoordAttribLocation, 2, VertexAttribPointerType.Float, true, sizeof(float) * 8, sizeof(float) * 6);

                //draw
                GL.DrawArrays(BeginMode.TriangleStrip, 0, BufferLen);
            }
            angle++;
            if (angle >= 36000)
            {
                angle = 0;
            }
            test_Shader.End();
        }
        ///<summary>
        ///Finsh
        ///</summary>
        public override void Finish()
        {
            test_Shader.Finish();
            
            GL.DeleteBuffers(1, ref m_CombineBuffer);

                // Console app
                System.Environment.Exit(1);
            
        }
    }
}
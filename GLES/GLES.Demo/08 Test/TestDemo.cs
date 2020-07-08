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
    public class TestDemo : DemoBase
    {
        int m_Width, m_Height;
        float [] Index;

        BasicShader test_Shader;

        //Buffers
        int m_CombineBuffer, m_IndexBuffer;

        ///<summary>
        ///Constructor
        ///</summary>
        public TestDemo()
        {
            test_Shader = new BasicShader();

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
            GL.GenBuffers(1, out m_CombineBuffer);
            GL.GenBuffers(1, out m_IndexBuffer);

            //Call the function to load the buffers
            LoadBuffers();
        }
        ///<summary>
        ///Load Buffers
        ///</summary>
        public void LoadBuffers()
        {
            //Create Buffer
            float[] Buffer = new float[]
            {
               // Coordinates           //Colours           //Textures
                100.0f,  100.0f, 1.0f,    1.0f, 0.0f, 0.0f,   1, 1,
                100.0f, -100.0f, 1.0f,    0.0f, 1.0f, 0.0f,   1, 0,
               -100.0f,  100.0f, 1.0f,    0.0f, 0.0f, 1.0f,   0, 1,
               -100.0f, -100.0f, 1.0f,    1.0f, 1.0f, 1.0f,   0, 0,
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
        ///<summary>
        ///Render
        ///</summary>
        public override void Render()
        {
            //Framebuffer
            GL.BindFramebuffer(FramebufferTarget.Framebuffer, 0);
            GL.ClearColor(0.2f, 0.2f, 0.2f, 1f);

            //resize window
            OnResize(m_Width, m_Height);

            test_Shader.Begin();
            //reset the model view matrix
            m_ModelViewMatrix = Matrix4.Identity;

            test_Shader.UpdateProjectionMatrix(m_ProjectionMatrix);
            test_Shader.UpdateModelViewMatrix(m_ModelViewMatrix);

            //ensure Vertex, color, Texture attrib
            GL.EnableVertexAttribArray(test_Shader.VertexAttribLocation);
            GL.EnableVertexAttribArray(test_Shader.ColorAttribLocation);
            //GL.EnableVertexAttribArray(test_Shader.TextureCoordAttribLocation);

            //Find Data
            GL.BindBuffer(BufferTarget.ArrayBuffer, m_CombineBuffer);
            GL.VertexAttribPointer(test_Shader.VertexAttribLocation, 3, VertexAttribPointerType.Float, true, sizeof(float) * 8, 0);
            GL.VertexAttribPointer(test_Shader.ColorAttribLocation, 3, VertexAttribPointerType.Float, true, sizeof(float) * 8, sizeof(float) * 3);
            //GL.VertexAttribPointer(test_Shader.TextureCoordAttribLocation, 2, VertexAttribPointerType.Float, true, sizeof(float) * 8, sizeof(float) * 6);

            GL.DrawArrays(BeginMode.Triangles, 0, 3);
            //draw
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, m_IndexBuffer);
            //GL.DrawElements(BeginMode.Triangles, Index.Length, DrawElementsType.UnsignedShort, IntPtr.Zero);
            //GL.DrawElements(PrimitiveType.Triangles, Index.Length, DrawElementsType.UnsignedInt, 0);

            test_Shader.End();

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

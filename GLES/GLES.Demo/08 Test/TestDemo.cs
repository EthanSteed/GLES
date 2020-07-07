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

            // generate buffers for triangle data.
            GL.GenBuffers(1, out m_VertexBuffer);
            GL.GenBuffers(1, out m_ColorBuffer);

            // load some data into these buffers.
            LoadBuffers();
        }

        /// <summary>
        /// Load up the buffers with data.
        /// </summary>
        private void LoadBuffers()
        {
            // Load Vertex Buffer.
            Vector3[] verts = new Vector3[] {
                new Vector3(-100, -100, 1 ),
                new Vector3(   0,  100, 1 ),
                new Vector3( 100, -100, 1 ) };

            GL.BindBuffer(BufferTarget.ArrayBuffer, m_VertexBuffer);
            GL.BufferData(BufferTarget.ArrayBuffer, new IntPtr(verts.Length * Vector3.SizeInBytes), verts, BufferUsage.StaticDraw);

            // Load Color Buffer.
            Vector4[] colors = new Vector4[]
            {
                new Vector4(1,0,0,1),
                new Vector4(0,1,0,1),
                new Vector4(0,0,1,1)
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
            // reset the model view matrix.
            m_ModelViewMatrix = Matrix4.Identity;

            // apply a rotation to the model view.
            m_ModelViewMatrix = Matrix4.Mult(m_ModelViewMatrix, Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(angle)));

            // begin using the shader. 
            m_Shader.Begin();

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
            GL.DrawArrays(BeginMode.Triangles, 0, 3);

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

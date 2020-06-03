using System;
using GLES.Shader;
using OpenTK.Graphics;
using OpenTK.Maths;

namespace GLES.Demo
{
    /// <summary>
    /// Draws a triangle.
    /// </summary>
    public class Demo01Triangle : IDemo
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
        public Demo01Triangle()
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
            m_ProjectionMatrix = Matrix4.CreateOrthographic(width, height, -100.0f, 100.0f);            
        }


        float angle = 0;

        /// <summary>
        /// Render
        /// </summary>
        public void Render(IGLPlatform glp)
        {
            // clear everything.
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit | ClearBufferMask.StencilBufferBit);

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
            GL.BindBuffer(BufferTarget.ArrayBuffer, m_VertexBuffer);
            GL.VertexAttribPointer(m_Shader.VertexAttribLocation, 3, VertexAttribPointerType.Float, true, Vector3.SizeInBytes, 0);

            // now the colours
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

            // Swap buffers
            glp.SwapBuffers();
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

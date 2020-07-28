using GLES.Shader;
using OpenTK.Graphics;
using OpenTK.Maths;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GLES.Demo
{
    /// <summary>
    /// Demo 02 Line
    /// </summary>
    [Demo('2', "Draw some lines")]
    public class LineDemo : IDemo
    {
        Matrix4 m_ProjectionMatrix;
        Matrix4 m_ModelViewMatrix;

        BasicShader m_Shader;

        int m_VertexBuffer;
        int m_ColorBuffer;

        /// <summary>
        /// Constructor
        /// </summary>
        public LineDemo()
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
            // Clear Color 
            GL.ClearColor(0.2f, 0.2f, 0.2f, 1f);

            // Initialise Shader
            m_Shader.Initialise();

            // Generate buffers
            GL.GenBuffers(1, out m_VertexBuffer);
            GL.GenBuffers(1, out m_ColorBuffer);

            // Load data into buffers
            LoadBuffers();
        }

        /// <summary>
        /// Load Buffers
        /// </summary>
        public void LoadBuffers()
        {
            Vector3[] verts = new Vector3[]
            {
                new Vector3 (-100,  100, 1 ),
                new Vector3 ( 100, -100, 1 ),
                new Vector3 (-300,   30, 1 ),
                new Vector3 (-300, -130, 1 ),
                new Vector3 (   0, -100, 1 ),
                new Vector3 (   0,  100, 1 ),
                new Vector3 ( 300,   30, 1 ),
                new Vector3 ( 300, -130, 1 )
            };

            // Bind Vertex Buffer
            GL.BindBuffer(BufferTarget.ArrayBuffer, m_VertexBuffer);

            // Add verts as the buffer's data
            GL.BufferData(BufferTarget.ArrayBuffer, new IntPtr(verts.Length * Vector3.SizeInBytes), verts, BufferUsage.StaticDraw);

            // Load Color Buffer.
            Vector4[] colors = new Vector4[]
            {
                new Vector4 (0, 0, 0.75f, 1),
                new Vector4 (0, 0, 0.75f, 1),
                new Vector4 (1, 0, 0.75f, 1),
                new Vector4 (1, 0, 0.75f, 1),
                new Vector4 (1, 0, 0    , 1),
                new Vector4 (1, 0, 0    , 1),
                new Vector4 (0, 1, 0    , 1),
                new Vector4 (0, 1, 0    , 1)
            };

            // Bind color buffer
            GL.BindBuffer(BufferTarget.ArrayBuffer, m_ColorBuffer);
            
            // Add colors as the buffer's data
            GL.BufferData(BufferTarget.ArrayBuffer, new IntPtr(colors.Length * Vector4.SizeInBytes), colors, BufferUsage.StaticDraw);
        }

        /// <summary>
        /// On Resize window event
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
            GL.Viewport(0, 0, width, height); ;
        }

        /// <summary>
        /// Handle key press. (Not used)
        /// </summary>
        /// <param name="key"></param>
        public bool HandleKeyPress(char key)
        {
            return false;
        }

        public bool HandleMouseMove(int Pos)
        {
            return false;
        }

        /// <summary>
        /// Allow Demo to Handle Mouse Wheel
        ///</summary>
        public bool HandleMouseWheel(int Delta)
        {
            return false;
        }

        /// <summary>
        /// Render Method
        /// </summary>
        public void Render()
        {            
            // Reset the model matrix
            m_ModelViewMatrix = Matrix4.Identity;

            // Being using the shader
            m_Shader.Begin();

            // Update Projection and model matrix
            m_Shader.UpdateProjectionMatrix(m_ProjectionMatrix);
            m_Shader.UpdateModelViewMatrix(m_ModelViewMatrix);

            // Enable attrib first
            GL.EnableVertexAttribArray(m_Shader.VertexAttribLocation);

            // Point to vertex buffer now
            GL.BindBuffer(BufferTarget.ArrayBuffer, m_VertexBuffer);

            // Set Attribute
            GL.VertexAttribPointer(m_Shader.VertexAttribLocation, 3, VertexAttribPointerType.Float, true, Vector3.SizeInBytes, 0);

            // Now to colour buffer

            // enable attrib first
            GL.EnableVertexAttribArray(m_Shader.ColorAttribLocation);

            // Point to colour buffer now
            GL.BindBuffer(BufferTarget.ArrayBuffer, m_ColorBuffer);

            // Set Attribute
            GL.VertexAttribPointer(m_Shader.ColorAttribLocation, 4, VertexAttribPointerType.Float, true, Vector4.SizeInBytes, 0);

            // Draw Lines
            GL.DrawArrays(BeginMode.LineStrip, 0, 8);

            m_Shader.End();
        }

        /// <summary>
        ///  Remember to clear resources here!
        /// </summary>
        public void Finish()
        {
            // Finish up shader
            m_Shader.Finish();

            // Clear up buffers
            GL.DeleteBuffers(1, ref m_VertexBuffer);
            GL.DeleteBuffers(1, ref m_ColorBuffer);
        }

    }
}

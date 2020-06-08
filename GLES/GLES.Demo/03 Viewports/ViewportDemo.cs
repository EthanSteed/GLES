using System;
using GLES.Shader;
using OpenTK.Graphics;
using OpenTK.Maths;

namespace GLES.Demo
{
    /// <summary>
    /// Demo 03 Viewports
    /// </summary>
    [Demo('3', "Multiple viewports")]
    public class ViewportDemo : IDemo
    {
        TriangleDemo m_Demo01;
        LineDemo m_Demo02;

        int m_WindowWidth = 500;
        int m_WindowHeight = 500;

        /// <summary>
        /// Constructor
        /// </summary>
        public ViewportDemo()
        {
            m_Demo01 = new TriangleDemo();
            m_Demo02 = new LineDemo();
        }

        /// <summary>
        /// Initialise
        /// </summary>
        public void Initialise()
        {
            // Clear Color 
            GL.ClearColor(0.2f, 0.2f, 0.2f, 1f);

            m_Demo01.Initialise();
            m_Demo02.Initialise();
        }

        /// <summary>
        /// On Resize window event
        /// </summary>
        public void OnResize(int width, int height)
        {
            m_WindowWidth = width;
            m_WindowHeight = height;

            // so that the ortho function is set up correctly tell the demos that
            // they are drawing to half of the width. This will make the 
            // GL coordinate units 1 to 1 with the window pixels
            m_Demo01.OnResize(width/2, height);
            m_Demo02.OnResize(width/2, height);
        }

        /// <summary>
        /// Handle key press. (Not used)
        /// </summary>
        /// <param name="key"></param>
        public bool HandleKeyPress(char key)
        {
            return false;
        }

        /// <summary>
        /// Render Method
        /// </summary>
        public void Render()
        {
            int wid2 = m_WindowWidth / 2;

            // Draw demo 1 on the first half of the window
            GL.Viewport(0, 0, wid2, m_WindowHeight);
            m_Demo01.Render();

            // Draw demo 2 on the second half of the window.
            GL.Viewport(wid2, 0, wid2, m_WindowHeight);
            m_Demo02.Render();
        }

        /// <summary>
        ///  Remember to clear resources here!
        /// </summary>
        public void Finish()
        {
            m_Demo01.Finish();
            m_Demo02.Finish();
        }

    }
}

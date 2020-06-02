using System.Windows.Markup;
using OpenTK.Graphics;
using OpenTK.Maths;

namespace GLES.Demos
{
    /// <summary>
    /// Draws a triangle.
    /// </summary>
    public class Demo01Triangle : IDemo
    {
        public void Initialise()
        {
            GL.ClearColor(0f, 1f, 0f, 1f);

        }

        /// <summary>
        /// Window has resized
        /// </summary>
        public void OnResize(int width, int height)
        {
            Matrix4 projectionMatrix = Matrix4.CreateOrthographic(width, height, -100.0f, 100.0f);
            Matrix4 modelviewMatrix = Matrix4.Identity;
        }

        public void Render()
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
        }

        public void Finish()
        {
        }

    }
}

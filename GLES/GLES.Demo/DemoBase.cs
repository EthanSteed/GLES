using OpenTK.Graphics;
using OpenTK.Maths;
//using System.Drawing;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;

namespace GLES.Demo
{
    public class DemoBase : IDemo
    {

        protected Matrix4 m_ProjectionMatrix;
        protected Matrix4 m_ModelViewMatrix;
        protected Matrix4 m_ViewMatrix;
        
        /// <summary>
        /// Initialise
        /// </summary>
        public virtual void Initialise()
        {
            m_ProjectionMatrix = Matrix4.Identity;
            m_ModelViewMatrix = Matrix4.Identity;
            m_ViewMatrix = Matrix4.Identity;
        }

        /// <summary>
        /// OnResize
        /// </summary>
        public virtual void OnResize(int width, int height)
        {
            // this sets up GL units to use for the display. We simply set the GL units 
            // to match the pixel units of the current window. Create Ortho sets the coordinate
            // system to +/- width/2 and +/- height/2  so 0,0 will be in the center of the window
            // -width/2, -height/2 will be in the bottom left.
            m_ProjectionMatrix = Matrix4.CreateOrthographic(width, height, -500, 500);

            // Viewport says what part of the window are we going to render to. We will
            // just set this to the window size width. You could choose to just render to 
            // a small square on the window if you wanted to. What ever size of viewport you choose
            // the ortho coordinate system will still be the same as above. Best thing to do
            // is to experiment changing the viewport width / height to see the effects.
            GL.Viewport(0, 0, width, height);
        }


        /// <summary>
        /// HandleKeyPress
        /// </summary>
        public virtual bool HandleKeyPress(char key)
        {
            return false;
        }

        /// <summary>
        /// Allow demo to handle Mouse movement.
        /// </summary>
        public virtual bool HandleMouseMove(double Xpos, double Ypos, IInputElement Window)
        {
            return false;
        }

        /// <summary>
        /// Allow Demo to Handle Mouse Wheel
        ///</summary>
        public virtual bool HandleMouseWheel(int Delta)
        {
            return false;
        }
        /// <summary>

        /// <summary>
        /// Render
        /// </summary>
        public virtual void Render()
        {
        }

        /// <summary>
        /// Finish
        /// </summary>
        public virtual void Finish()
        {
        }
    }
}

using System;
using GLES.Shader;
using OpenTK.Graphics;
using OpenTK.Maths;

namespace GLES.Demo
{
    [Demo(5, "Frame Buffer")]
    public class FrameBufferDemo : IDemo
    {
        Matrix4 m_ProjectionMatrix;
        Matrix4 m_ModelViewMatrix;

        BasicShader m_Shader;

        /// <summary>
        /// Constructor
        /// </summary>
        public FrameBufferDemo()
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
            m_Shader.Initialise();
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
        /// Render
        /// </summary>
        public void Render()
        {
            // reset the model view matrix.
            m_ModelViewMatrix = Matrix4.Identity;

            // begin using the shader. 
            m_Shader.Begin();


            // finished with the shader.
            m_Shader.End();
        }

        /// <summary>
        /// Finish
        /// </summary>
        public void Finish()
        {
            // finished with the shader
            m_Shader.Finish();
        }

    }
}

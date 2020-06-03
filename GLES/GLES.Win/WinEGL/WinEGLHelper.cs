using System;

namespace GLES
{
    public class WinEGLHelper : IGLPlatform
    {
        private IntPtr m_Display;
        private IntPtr m_Surface;

        /// <summary>
        /// Try initialise EGL on a window.
        /// </summary>
        /// <param name="winhandle"></param>
        /// <param name="display"></param>
        /// <param name="window"></param>
        /// <returns></returns>
        public void InitialiseEGLOnWindow(IntPtr winhandle)
        {
            m_Display = WinEGL.GetDisplay(WinEGL.DEFAULT_DISPLAY);

            int major, minor;
            if (!WinEGL.Initialize(m_Display, out major, out minor))
            {
                int error = WinEGL.GetError();
                throw new InvalidOperationException("Could not initialise graphics. Error code = " + error);
            }

            WinEGL.BindAPI(WinEGL.OPENGL_ES_API);
            if (WinEGL.GetError() != WinEGL.SUCCESS)
            {
                throw new InvalidOperationException("Could not bind to opengl ES");
            }

            int[] configAttributes = new int[]
            {
                WinEGL.RED_SIZE, 8,
                WinEGL.GREEN_SIZE, 8,
                WinEGL.BLUE_SIZE, 8,
                WinEGL.ALPHA_SIZE, 8,
                WinEGL.DEPTH_SIZE, 24,
                WinEGL.STENCIL_SIZE, 8,
                WinEGL.SAMPLE_BUFFERS, WinEGL.DONT_CARE,
                WinEGL.NONE
            };

            IntPtr config;
            int configCount;
            if (!WinEGL.ChooseConfig(m_Display, configAttributes, out config, 1, out configCount) || (configCount != 1))
            {
                throw new InvalidOperationException("Could not choose config");
            }

            int[] surfaceAttributes = new int[]{
                WinEGL.NONE,
                WinEGL.NONE
            };

            m_Surface = WinEGL.CreateWindowSurface(m_Display, config, winhandle, surfaceAttributes);
            if (m_Surface == IntPtr.Zero)
            {
                WinEGL.GetError();
                m_Surface = WinEGL.CreateWindowSurface(m_Display, config, IntPtr.Zero, null);
            }

            if (WinEGL.GetError() != WinEGL.SUCCESS)
            {
                throw new InvalidOperationException("Could not create window surface");
            }

            int[] contextAttributes = new int[]
            {
                WinEGL.CONTEXT_CLIENT_VERSION, 2, WinEGL.NONE
            };

            IntPtr context = WinEGL.CreateContext(m_Display, config, IntPtr.Zero, contextAttributes);
            if (WinEGL.GetError() != WinEGL.SUCCESS)
            {
                throw new InvalidOperationException("Could not create context");
            }

            WinEGL.MakeCurrent(m_Display, m_Surface, m_Surface, context);
            if (WinEGL.GetError() != WinEGL.SUCCESS)
            {
                throw new InvalidOperationException("Could not make surface current");
            }

            // turn off vsync.
            WinEGL.SwapInterval(m_Display, 0);

        }

        /// <summary>
        /// Swap buffers
        /// </summary>
        public void SwapBuffers()
        {
            WinEGL.SwapBuffers(m_Display, m_Surface);
        }

    }
}

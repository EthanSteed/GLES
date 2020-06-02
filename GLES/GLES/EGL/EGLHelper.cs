using System;

namespace GLES
{
    public class EGLHelper
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
            m_Display = EGL.GetDisplay(EGL.DEFAULT_DISPLAY);

            int major, minor;
            if (!EGL.Initialize(m_Display, out major, out minor))
            {
                int error = EGL.GetError();
                throw new InvalidOperationException("Could not initialise graphics. Error code = " + error);
            }

            EGL.BindAPI(EGL.OPENGL_ES_API);
            if (EGL.GetError() != EGL.SUCCESS)
            {
                throw new InvalidOperationException("Could not bind to opengl ES");
            }

            int[] configAttributes = new int[]
            {
                EGL.RED_SIZE, 8,
                EGL.GREEN_SIZE, 8,
                EGL.BLUE_SIZE, 8,
                EGL.ALPHA_SIZE, 8,
                EGL.DEPTH_SIZE, 24,
                EGL.STENCIL_SIZE, 8,
                EGL.SAMPLE_BUFFERS, EGL.DONT_CARE,
                EGL.NONE
            };

            IntPtr config;
            int configCount;
            if (!EGL.ChooseConfig(m_Display, configAttributes, out config, 1, out configCount) || (configCount != 1))
            {
                throw new InvalidOperationException("Could not choose config");
            }

            int[] surfaceAttributes = new int[]{
                EGL.NONE,
                EGL.NONE
            };

            m_Surface = EGL.CreateWindowSurface(m_Display, config, winhandle, surfaceAttributes);
            if (m_Surface == IntPtr.Zero)
            {
                EGL.GetError();
                m_Surface = EGL.CreateWindowSurface(m_Display, config, IntPtr.Zero, null);
            }

            if (EGL.GetError() != EGL.SUCCESS)
            {
                throw new InvalidOperationException("Could not create window surface");
            }

            int[] contextAttributes = new int[]
            {
                EGL.CONTEXT_CLIENT_VERSION, 2, EGL.NONE
            };

            IntPtr context = EGL.CreateContext(m_Display, config, IntPtr.Zero, contextAttributes);
            if (EGL.GetError() != EGL.SUCCESS)
            {
                throw new InvalidOperationException("Could not create context");
            }

            EGL.MakeCurrent(m_Display, m_Surface, m_Surface, context);
            if (EGL.GetError() != EGL.SUCCESS)
            {
                throw new InvalidOperationException("Could not make surface current");
            }

            // turn off vsync.
            EGL.SwapInterval(m_Display, 0);

        }

        /// <summary>
        /// Swap buffers
        /// </summary>
        public void SwapBuffers()
        {
            EGL.SwapBuffers(m_Display, m_Surface);
        }

    }
}

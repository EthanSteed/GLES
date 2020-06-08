using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GLES.Demo;
using GLES.PI.PIEGL;
using OpenTK.Graphics;

namespace GLES.PI
{
    class Program
    {
        const int SCREEN_WIDTH = 1024;
        const int SCREEN_HEIGHT = 768;

        static IDemo m_CurrentDemo;

        static bool m_Exit = false;

        static Stopwatch m_Stopwatch = new Stopwatch();
        static int m_Fps = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("PI GLES Demo. Press q to quit");
            Console.WriteLine("Initialising Graphics");

            // initalise pi graphics
            int init = PIGLHelper.Initialise();

            if (init != 0)
            {
                Console.WriteLine("Failed to initialise GL ES context");
                return;            
            }

            // redirect trace / debug messages to the console.
            ConsoleTraceListener ctl = new ConsoleTraceListener();
            System.Diagnostics.Trace.Listeners.Add(ctl);

            GL.ClearColor(0, 0, 1, 1);
            GL.Disable(EnableCap.CullFace);

            SetCurrentDemo('1');

            m_Stopwatch.Start();


            // loop until exit.
            while (!m_Exit)
            {
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

                m_CurrentDemo.Render();

                PIGLHelper.SwapBuffers();

                DoRenderStats();

                HandleKeyPress();
            }

            // finish
            PIGLHelper.Cleanup();
        }

        /// <summary>
        /// DoRenderStats
        /// </summary>
        private static void DoRenderStats()
        {
            // check for errors
            var ec = GL.GetError();
            if (ec != ErrorCode.NoError)
            {
                Console.WriteLine(string.Format("GL ERROR {0}", ec));
            }

            // do FPS check
            m_Fps++;
            if (m_Stopwatch.ElapsedMilliseconds >= 1000)
            {
                Console.WriteLine("GLES DEMO - FPS {0}", m_Fps);
                m_Fps = 0;
                m_Stopwatch.Restart();
            }
        }

        /// <summary>
        /// Handle key press.
        /// </summary>
        private static void HandleKeyPress()
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey();

                // see if current demo is handling the key press.
                if (!m_CurrentDemo.HandleKeyPress(key.KeyChar))
                {
                    // exit on q
                    if (key.KeyChar == 'q')
                    {
                        m_Exit = true;
                    }
                    else
                    // choose demo.
                    {
                        SetCurrentDemo(key.KeyChar);
                    }
                }

            }
        }

        /// <summary>
        /// Set the current demo
        /// </summary>
        private static void SetCurrentDemo(char id)
        {
            // initialise
            Console.WriteLine(string.Format("Initalising Demo : {0}", id));
            m_CurrentDemo = DemoFactory.GetDemo(id);
            m_CurrentDemo.Initialise();

            // fire the resize event so demo's can set up their viewport
            m_CurrentDemo.OnResize(SCREEN_WIDTH, SCREEN_HEIGHT);
        }
    }
}

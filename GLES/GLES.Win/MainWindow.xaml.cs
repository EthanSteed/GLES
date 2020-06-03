using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using GLES.Demo;
using OpenTK.Graphics;

namespace GLES.Win
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WinEGLHelper m_EglHelper;

        IDemo m_CurrentDemo;

        public MainWindow()
        {
            InitializeComponent();

            m_EglHelper = new WinEGLHelper();

            this.Loaded += MainWindow_Loaded;            


        }

        /// <summary>
        /// Called when user resizes the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            m_CurrentDemo.OnResize((int)e.NewSize.Width, (int)e.NewSize.Height);
        }

        /// <summary>
        /// Initialise an EGL window to draw on.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {

            // start stopwatch
            m_Stopwatch.Start();

            // initialise EGL
            m_EglHelper.InitialiseEGLOnWindow(new WindowInteropHelper(this).Handle);

            // set blue clear color
            GL.ClearColor(0, 0, 1, 1);

            // initialise
            m_CurrentDemo = DemoFactory.GetDemo(2);
            m_CurrentDemo.Initialise();

            // fire the resize event so demo's can set up their viewport
            m_CurrentDemo.OnResize((int)this.Width, (int)this.Height);

            // link up to any further changes in window size changed.
            this.SizeChanged += MainWindow_SizeChanged;

            // start rendering.
            CompositionTarget.Rendering += Render;

            // check init time and restart stopwatch for fps check.
            System.Diagnostics.Debug.WriteLine(string.Format("Initialised in {0}ms", m_Stopwatch.ElapsedMilliseconds));
            m_Stopwatch.Restart();

        }

        /// <summary>
        /// link into render event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Render(object sender, EventArgs e)
        {
            // Render
            m_CurrentDemo.Render(m_EglHelper);

            // check for errors
            var ec = GL.GetError();
            if (ec != ErrorCode.NoError)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("GL ERROR {0}", ec));
            }

            // do FPS check
            m_Fps++;
            if (m_Stopwatch.ElapsedMilliseconds >= 1000)
            {
                this.Title = string.Format("GLES DEMO - FPS {0}", m_Fps);
                m_Fps = 0;
                m_Stopwatch.Restart();
            }

        }

        // Frames per second check.
        Stopwatch m_Stopwatch = new Stopwatch();
        int m_Fps = 0;
    }
}

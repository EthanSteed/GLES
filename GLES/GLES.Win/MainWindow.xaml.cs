using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows;
using System.Windows.Input;
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
            this.TextInput += MainWindow_TextInput;

            this.PreviewMouseMove += MainWindow_PreviewMouseMove;
            this.PreviewMouseWheel += MainWindow_PreviewMouseWheel;
            
            
        }

        private void MainWindow_PreviewMouseWheel(object sender, MouseWheelEventArgs W)
        {
            if (!m_CurrentDemo.HandleMouseWheel(W.Delta))
            {

            }
        }

        private void MainWindow_PreviewMouseMove(object sender, MouseEventArgs M)
        {
            System.Windows.Point XY = M.GetPosition(this.MainDrawArea);

            System.Windows.Forms.Cursor.Hide();
            this.MainDrawArea.CaptureMouse();

            if (!m_CurrentDemo.HandleMouseMove(XY.X, XY.Y, this.MainDrawArea))
            {
                
            }
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

            SetCurrentDemo('1');
                
            // link up to any further changes in window size changed.
            this.SizeChanged += MainWindow_SizeChanged;

            // start rendering.
            CompositionTarget.Rendering += Render;

            // check init time and restart stopwatch for fps check.
            System.Diagnostics.Debug.WriteLine(string.Format("Initialised in {0}ms", m_Stopwatch.ElapsedMilliseconds));
            m_Stopwatch.Restart();

        }

        /// <summary>
        /// Set the current demo
        /// </summary>
        private void SetCurrentDemo(char id)
        {
            // initialise
            m_CurrentDemo = DemoFactory.GetDemo(id);
            m_CurrentDemo.Initialise();

            // fire the resize event so demo's can set up their viewport
            m_CurrentDemo.OnResize((int)this.ActualWidth, (int)this.ActualHeight);
        }

        /// <summary>
        /// link into render event.
        /// </summary>
        private void Render(object sender, EventArgs e)
        {
            // clear everything.            
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit | ClearBufferMask.StencilBufferBit);

            // Render
            m_CurrentDemo.Render();

            // swap buffers
            m_EglHelper.SwapBuffers();

            // check for errors and calculate FPS
            DoRenderStats();
        }

        /// <summary>
        /// DoRenderStats
        /// </summary>
        private void DoRenderStats()
        {

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


        /// <summary>
        /// Listen to text input to the main window (E.g. key presses)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_TextInput(object sender, TextCompositionEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(e.Text))
            {
                // if not handled by current demo.
                if (!m_CurrentDemo.HandleKeyPress(e.Text[0]))
                {

                    // Finish Current Demo
                    m_CurrentDemo.Finish();

                    // id passed - Default Demo used if id out of range
                    SetCurrentDemo(e.Text[0]);
                }
            }

        }

        // Frames per second check.
        Stopwatch m_Stopwatch = new Stopwatch();
        int m_Fps = 0;
    }
}

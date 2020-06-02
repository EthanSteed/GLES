using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GLES.Demos;
using OpenTK.Graphics;

namespace GLES
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EGLHelper m_EglHelper;

        IDemo m_CurrentDemo;

        public MainWindow()
        {
            InitializeComponent();

            m_EglHelper = new EGLHelper();

            m_CurrentDemo = new Demo01Triangle();

            this.Loaded += MainWindow_Loaded;
            this.SizeChanged += MainWindow_SizeChanged;
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
            m_EglHelper.InitialiseEGLOnWindow(new WindowInteropHelper(this).Handle);

            // initialise
            m_CurrentDemo.Initialise();

            // fire the resize event so demo's can set up their viewport
            m_CurrentDemo.OnResize((int)this.Width, (int)this.Height);

            // set blue clear color
            GL.ClearColor(0, 0, 1, 1);
            
            // start rendering.
            CompositionTarget.Rendering += Render;                    
        }

        /// <summary>
        /// link into render event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Render(object sender, EventArgs e)
        {
            // clear everything.
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit | ClearBufferMask.StencilBufferBit);

            // Render
            m_CurrentDemo.Render();
            
            // swap
            m_EglHelper.SwapBuffers();
            
        }



    }
}

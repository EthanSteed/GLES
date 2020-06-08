using System.Runtime.InteropServices;

namespace GLES.PI.PIEGL
{

    /// <summary>
    /// Creates a gl es context direct to the framebuffer. No X windows
    /// </summary>
    public class PIGLHelper
    {
        [DllImport("glPiContext.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SwapBuffers();

        [DllImport("glPiContext.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Cleanup();

        [DllImport("glPiContext.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Initialise();
    }
}

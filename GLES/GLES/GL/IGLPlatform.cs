using System;
using System.Collections.Generic;
using System.Text;

namespace GLES
{
    /// <summary>
    /// Interface for a GL platform
    /// </summary>
    public interface IGLPlatform
    {
        /// <summary>
        /// Allow swap buffers
        /// </summary>
        void SwapBuffers();
    }
}

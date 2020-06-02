using System;

namespace GLES.Shader
{
    /// <summary>
    /// A shader exception
    /// </summary>
    public class ShaderException : Exception
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ShaderException()
        {
        }

        /// <summary>
        /// Constructor with msg
        /// </summary>
        /// <param name="msg"></param>
        public ShaderException(string msg) : base(msg) 
        { 
        }
    }
}

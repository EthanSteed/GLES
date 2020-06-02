using System;
using OpenTK.Graphics;

namespace GLES.Shader
{
    /// <summary>
    /// Base class for all shaders
    /// </summary>
    public abstract class Shader
    {
        private const int GL_SUCCESS = 1;

        private int m_FragmentShader;

        private int m_VertexShader;

        protected int m_Program;

        /// <summary>
        /// Constructor
        /// </summary>
        public Shader()
        {
        }

        /// <summary>
        /// Initialise
        /// </summary>
        /// <param name="fragmentShaderSrc">Fragment shader source.</param>
        /// <param name="vertexShaderSrc">Vertex shader source</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ShaderException"></exception>
        public virtual void Initialise(string fragmentShaderSrc, string vertexShaderSrc)
        {
            Valid = false;

            if (string.IsNullOrWhiteSpace(fragmentShaderSrc) || string.IsNullOrWhiteSpace(vertexShaderSrc))
            {
                throw new ArgumentException("shader source must not be null or empty.");
            }

            CreateFragmentShader(fragmentShaderSrc);

            CreateVertexShader(vertexShaderSrc);

            CreateProgram();

            Valid = true;
        }

        /// <summary>
        /// Create the fragment shader
        /// </summary>
        /// <param name="fragmentShaderSrc"></param>
        private void CreateFragmentShader(string fragmentShaderSrc)
        {
            m_FragmentShader = GL.CreateShader(ShaderType.FragmentShader);

            if (m_FragmentShader <= 0)
            {
                throw new ShaderException("Could not create fragment shader");
            }

            GL.ShaderSource(m_FragmentShader, fragmentShaderSrc);

            GL.CompileShader(m_FragmentShader);

            int compileResult;
            GL.GetShader(m_FragmentShader, ShaderParameter.CompileStatus, out compileResult);

            string compileLog;
            GL.GetShaderInfoLog(m_FragmentShader, out compileLog);

            if (compileResult != GL_SUCCESS)
            {
                throw new ShaderException("Fragment shader compilation error : " + compileLog);
            }

            if (compileLog.Contains("WARNING"))
            {
                System.Diagnostics.Debug.WriteLine("Fragment Shader Warning : " + compileLog);
            }

        }

        /// <summary>
        /// Create the vertex shader
        /// </summary>
        /// <param name="vertexShaderSrc"></param>
        private void CreateVertexShader(string vertexShaderSrc)
        {
            m_VertexShader = GL.CreateShader(ShaderType.VertexShader);

            if (m_VertexShader <= 0)
            {
                throw new ShaderException("could not create vertex shader");
            }

            GL.ShaderSource(m_VertexShader, vertexShaderSrc);

            GL.CompileShader(m_VertexShader);

            int compileResult;
            GL.GetShader(m_VertexShader, ShaderParameter.CompileStatus, out compileResult);

            string compileLog;
            GL.GetShaderInfoLog(m_VertexShader, out compileLog);

            if (compileResult != GL_SUCCESS)
            {
                throw new ShaderException("Vertex shader compilation error : " + compileLog);
            }

            if (compileLog.Contains("WARNING"))
            {
                System.Diagnostics.Debug.WriteLine("Vertex Shader Warning : " + compileLog);

            }

        }

        /// <summary>
        /// Create Program
        /// </summary>
        private void CreateProgram()
        {
            m_Program = GL.CreateProgram();

            GL.AttachShader(m_Program, m_FragmentShader);
            GL.AttachShader(m_Program, m_VertexShader);

            GL.LinkProgram(m_Program);

            int linkResult;
            GL.GetProgram(m_Program, ProgramParameter.LinkStatus, out linkResult);

            string programLog;
            GL.GetProgramInfoLog(m_Program, out programLog);

            if (linkResult != GL_SUCCESS)
            {
                throw new ShaderException("Could not link program : " + programLog);
            }

            if (!string.IsNullOrEmpty(programLog))
            {
                System.Diagnostics.Debug.WriteLine(programLog);
            }
        }

        /// <summary>
        /// Start use of this program
        /// </summary>
        public virtual void Begin()
        {
            if (Valid)
            {
                GL.UseProgram(m_Program);
            }
        }

        /// <summary>
        /// End use of this program
        /// </summary>
        public virtual void End()
        {
            if (Valid)
            {
                GL.UseProgram(0);
            }
        }

        /// <summary>
        /// Clean up the shaders
        /// </summary>
        public virtual void Finish()
        {
            GL.DeleteProgram(m_Program);
            GL.DeleteShader(m_FragmentShader);
            GL.DeleteShader(m_VertexShader);
        }

        /// <summary>
        /// Indicates whether the shader is valid
        /// </summary>
        public bool Valid { get; protected set; }

    }



}

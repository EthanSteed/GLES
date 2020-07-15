using System.Reflection;
using OpenTK.Graphics;
using OpenTK.Maths;

namespace GLES.Shader
{
    /// <summary>
    /// A basic shader. 
    /// </summary>
    public class BasicShader : ShaderBase
    {
        /// <summary>
        /// The vertex attrib location
        /// </summary>
        public int VertexAttribLocation { get; set; }

        /// <summary>
        /// The color attrib location
        /// </summary>
        public int ColorAttribLocation { get; set; }

        /// <summary>
        /// location for the projection matrix
        /// </summary>
        public int ProjectionMatrixLocation { get; set; }

        /// <summary>
        /// Location for the model view matrix.
        /// </summary>
        public int ModelViewMatrixLocation { get; set; }

        ///<summary>
        /// View Matrix
        ///</summary>
        public int ViewMatrixLocation { get; set; }

        /// <summary>
        /// Initialise the shader
        /// </summary>
        public void Initialise()
        {
            try
            {
                string fs;
                EmbeddedResourceHelper.GetEmbeddedFileAsString(Assembly.GetExecutingAssembly(), "basicshader.frag", out fs);

                string vs;
                EmbeddedResourceHelper.GetEmbeddedFileAsString(Assembly.GetExecutingAssembly(), "basicshader.vert", out vs);

                base.Initialise(fs, vs);

                // get attribute locations
                VertexAttribLocation = GL.GetAttribLocation(m_Program, "aVert");
                ColorAttribLocation = GL.GetAttribLocation(m_Program, "aColor");
                
                // get uniform locations
                ProjectionMatrixLocation = GL.GetUniformLocation(m_Program, "uProjection_matrix");
                ModelViewMatrixLocation = GL.GetUniformLocation(m_Program, "uModelview_matrix");
                ViewMatrixLocation = GL.GetUniformLocation(m_Program, "uViewMatrix");

            }
            catch (ShaderException se)
            {
                System.Diagnostics.Debug.WriteLine(se.Message);
            }

        }

        /// <summary>
        /// Update the model view matrix to use
        /// </summary>
        /// <param name="mat"></param>
        public void UpdateModelViewMatrix(Matrix4 mat)
        {
            GL.UniformMatrix4(ModelViewMatrixLocation, false, ref mat);
        }

        /// <summary>
        /// Update the projection matrix to use.
        /// </summary>
        /// <param name="mat"></param>
        public void UpdateProjectionMatrix(Matrix4 mat)
        {
            GL.UniformMatrix4(ProjectionMatrixLocation, false, ref mat);
        }

        /// <summary>
        /// Update the View matrix to use.
        /// </summary>
        /// <param name="mat"></param>
        public void UpdateViewMatrix(Matrix4 mat)
        {
            GL.UniformMatrix4(ViewMatrixLocation, false, ref mat);
        }
    }
}

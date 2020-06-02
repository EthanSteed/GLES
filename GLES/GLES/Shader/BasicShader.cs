using OpenTK.Graphics;
using OpenTK.Maths;

namespace GLES.Shader
{
    /// <summary>
    /// A basic shader. 
    /// </summary>
    public class BasicShader : Shader
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

        /// <summary>
        /// Initialise the shader
        /// </summary>
        public void Initialise()
        {
            try
            {
                string fs;
                ShaderHelper.GetEmbeddedShaderFile("basicshader.frag", out fs);

                string vs;
                ShaderHelper.GetEmbeddedShaderFile("basicshader.vert", out vs);

                base.Initialise(fs, vs);

                // get attribute locations
                VertexAttribLocation = GL.GetAttribLocation(m_Program, "aVert");
                ColorAttribLocation = GL.GetAttribLocation(m_Program, "aColor");
                
                // get uniform locations
                ProjectionMatrixLocation = GL.GetUniformLocation(m_Program, "uProjection_matrix");
                ModelViewMatrixLocation = GL.GetUniformLocation(m_Program, "uModelview_matrix");

            }
            catch (ShaderException se)
            {
                System.Diagnostics.Debug.WriteLine(se.Message);
            }

        }

        /// <summary>
        /// Begin the shader use.
        /// </summary>
        public override void Begin()
        {
            base.Begin();

            // ensure vertex and color attrib arrays are enabled.
            GL.EnableVertexAttribArray(VertexAttribLocation);
            GL.EnableVertexAttribArray(ColorAttribLocation);
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

    }
}

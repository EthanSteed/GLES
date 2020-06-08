using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using GLES.Shader;
using OpenTK.Graphics;
using OpenTK.Maths;

namespace GLES.Demo
{
    /// <summary>
    /// Font Shader
    /// </summary>
    public class FontShader : ShaderBase
    {
        /// <summary>
        /// The vertex attrib location
        /// </summary>
        public int VertexAttribLocation { get; set; }

        /// <summary>
        /// Texture Coord attrib location
        /// </summary>
        public int TextureCoordAttribLocation { get; set; }

        /// <summary>
        /// location for the projection matrix
        /// </summary>
        public int ProjectionMatrixLocation { get; set; }

        /// <summary>
        /// Location for the model view matrix.
        /// </summary>
        public int ModelViewMatrixLocation { get; set; }

        /// <summary>
        /// Location for the texture slot to use
        /// </summary>
        private int TextureSlotLocation { get; set; }

        /// <summary>
        /// Location for setting an alpha test.
        /// </summary>
        private int AlphaTestLocation { get; set; }

        /// <summary>
        /// Initialise the shader
        /// </summary>
        public void Initialise()
        {            
            try
            {
                string fs;
                EmbeddedResourceHelper.GetEmbeddedFileAsString(Assembly.GetExecutingAssembly(), "fontshader.frag", out fs);

                string vs;
                EmbeddedResourceHelper.GetEmbeddedFileAsString(Assembly.GetExecutingAssembly(), "fontshader.vert", out vs);

                base.Initialise(fs, vs);

                // get attribute locations
                VertexAttribLocation = GL.GetAttribLocation(m_Program, "aVert");
                TextureCoordAttribLocation = GL.GetAttribLocation(m_Program, "aTexCoord");

                // get uniform locations
                ProjectionMatrixLocation = GL.GetUniformLocation(m_Program, "uProjection_matrix");
                ModelViewMatrixLocation = GL.GetUniformLocation(m_Program, "uModelview_matrix");

                // get the texture sampler location
                TextureSlotLocation = GL.GetUniformLocation(m_Program, "uTexSlot0");

                AlphaTestLocation = GL.GetUniformLocation(m_Program, "uAlphaTest");
            }
            catch (ShaderException se)
            {
                System.Diagnostics.Debug.WriteLine(se.Message);
            }

        }
        

        /// <summary>
        /// Set which texture slot to use.
        /// </summary>
        /// <param name="slot"></param>
        public void SetTextureSlot(int slot)
        {
            // tell the shader what slot we want to read the texture data from.
            GL.Uniform1(TextureSlotLocation, slot);
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
        /// Update the alpha test value
        /// </summary>
        /// <param name="alpha"></param>
        public void UpdateAlphaTest(float alpha)
        {
            GL.Uniform1(AlphaTestLocation, alpha);
        }
    }
}

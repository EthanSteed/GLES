using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using GLES.Shader;
using OpenTK.Graphics;
using OpenTK.Maths;

namespace GLES.Shader
{
    public class CombineShader : BasicShader
    {

        /// <summary>
        /// Texture Coord attrib location
        /// </summary>
        public int TextureCoordAttribLocation { get; set; }

        /// <summary>
        /// Location for the texture slot to use
        /// </summary>
        private int TextureSlotLocation { get; set; }

        /// <summary>
        /// Initialise the shader
        /// </summary>
        public new void Initialise()
        {
            try
            {
                string fs;
                EmbeddedResourceHelper.GetEmbeddedFileAsString(Assembly.GetExecutingAssembly(), "Combineshader.frag", out fs);

                string vs;
                EmbeddedResourceHelper.GetEmbeddedFileAsString(Assembly.GetExecutingAssembly(), "Combineshader.vert", out vs);

                base.Initialise(fs, vs);

                // get attribute locations
                VertexAttribLocation = GL.GetAttribLocation(m_Program, "aVert");
                ColorAttribLocation = GL.GetAttribLocation(m_Program, "aColor");
                TextureCoordAttribLocation = GL.GetAttribLocation(m_Program, "aTexCoord");

                // get uniform locations
                ProjectionMatrixLocation = GL.GetUniformLocation(m_Program, "uProjection_matrix");
                ModelViewMatrixLocation = GL.GetUniformLocation(m_Program, "uModelview_matrix");

                // get the texture sampler location
                TextureSlotLocation = GL.GetUniformLocation(m_Program, "uTexSlot0");
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
    }
}


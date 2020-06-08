using System;
using System.Reflection;
using OpenTK.Graphics;
using OpenTK.Maths;

namespace GLES.Demo._04_Texture
{
    [Demo('4', "Applying a textures")]
    public class TextureDemo : DemoBase
    {
        TextureShader m_Shader;

        int m_VertexBuffer;
        int m_TexCoordBuffer;

        int m_Texture1;

        /// <summary>
        /// Constructor
        /// </summary>
        public TextureDemo()
        {
            m_Shader = new TextureShader();
        }

        /// <summary>
        /// Initialise
        /// </summary>
        public override void Initialise()
        {
            base.Initialise();

            m_Shader.Initialise();

            GL.GenBuffers(1, out m_VertexBuffer);
            GL.GenBuffers(1, out m_TexCoordBuffer);

            LoadBuffers();

            GL.GenTextures(1, out m_Texture1);

            InitAndLoadTexture();
        }


        /// <summary>
        /// Load up the buffers with data.
        /// </summary>
        private void LoadBuffers()
        {
            // Load Vertex Buffer.
            Vector3[] verts = new Vector3[] {
                new Vector3(-100,  100, 1 ),
                new Vector3( 100,  100, 1 ),
                new Vector3(-100,  -100, 1 ),
                new Vector3( 100,  -100, 1)  
            };

            GL.BindBuffer(BufferTarget.ArrayBuffer, m_VertexBuffer);
            GL.BufferData(BufferTarget.ArrayBuffer, new IntPtr(verts.Length * Vector3.SizeInBytes), verts, BufferUsage.StaticDraw);

            // Load TexCoords Buffer.
            Vector2[] texcoords = new Vector2[]
            {
                new Vector2(0,1),
                new Vector2(1,1),
                new Vector2(0,0),
                new Vector2(1,0)
            };

            GL.BindBuffer(BufferTarget.ArrayBuffer, m_TexCoordBuffer);
            GL.BufferData(BufferTarget.ArrayBuffer, new IntPtr(texcoords.Length * Vector2.SizeInBytes), texcoords, BufferUsage.StaticDraw);
        }

        /// <summary>
        /// Initialise and load a texture.
        /// </summary>
        private void InitAndLoadTexture()
        {
            // tell the graphics card what texture we are working with.
            GL.BindTexture(TextureTarget.Texture2D, m_Texture1);

            // set filtering and wrapping options.
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToEdge);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.ClampToEdge);

            // load the image data into the texture target.
            byte[] imgdata;
            EmbeddedResourceHelper.GetEmbeddedFileAsBytes(Assembly.GetExecutingAssembly(), "texturedemo.bmp", out imgdata);
                      
            unsafe
            {
                fixed (byte* p = imgdata)
                {
                    GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgb, 256, 256, 0, PixelFormat.Rgb, PixelType.UnsignedByte, (IntPtr)p);
                }
            }
            
        }

        float angle = 0;

        /// <summary>
        /// Render
        /// </summary>
        public override void Render()
        {
            // reset the model view matrix.
            m_ModelViewMatrix = Matrix4.Identity;

            // apply a rotation to the model view.
            m_ModelViewMatrix = Matrix4.Mult(m_ModelViewMatrix, Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(angle)));

            // begin using the shader. 
            m_Shader.Begin();

            // update the model and projection matrix
            m_Shader.UpdateProjectionMatrix(m_ProjectionMatrix);
            m_Shader.UpdateModelViewMatrix(m_ModelViewMatrix);

            // ensure vertex and color attrib arrays are enabled.
            GL.EnableVertexAttribArray(m_Shader.VertexAttribLocation);

            GL.BindBuffer(BufferTarget.ArrayBuffer, m_VertexBuffer);
            GL.VertexAttribPointer(m_Shader.VertexAttribLocation, 3, VertexAttribPointerType.Float, true, Vector3.SizeInBytes, 0);

            // now the texture coordinates
            GL.EnableVertexAttribArray(m_Shader.TextureCoordAttribLocation);

            GL.BindBuffer(BufferTarget.ArrayBuffer, m_TexCoordBuffer);
            GL.VertexAttribPointer(m_Shader.TextureCoordAttribLocation, 2, VertexAttribPointerType.Float, true, Vector2.SizeInBytes, 0);

            // bind our texture into slot 0. Try changing this so the shader looks at texture slot 5. You will notice
            // that the texture goes black. To fix it we then set the ActiveTexture to 5 and bind our texture data into 
            // it..
            m_Shader.SetTextureSlot(3);
            GL.ActiveTexture(TextureUnit.Texture3);
            GL.BindTexture(TextureTarget.Texture2D, m_Texture1);


            // draw a quad (made up of two triangles)
            GL.DrawArrays(BeginMode.TriangleStrip, 0, 4);

            // finished with the shader.
            m_Shader.End();

            // this will clear the texture data from the slot were are using. If we don't do this our texture
            // data will be left in the slot and could interfere with other drawing we are doing elsewhere.
            GL.BindTexture(TextureTarget.Texture2D, 0);

            // increment our rotation
            angle += 1;
            if (angle > 360)
            {
                angle = 0f;
            };
        }

        /// <summary>
        /// Finish
        /// </summary>
        public override void Finish()
        {
            // finished with the shader
            m_Shader.Finish();

            // free up the buffers.
            GL.DeleteBuffers(1, ref m_VertexBuffer);
            GL.DeleteBuffers(1, ref m_TexCoordBuffer);

            GL.DeleteTextures(1, ref m_Texture1);

        }


    }
}

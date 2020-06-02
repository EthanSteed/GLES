using System.IO;
using System.Reflection;

namespace GLES.Shader
{
    public class ShaderHelper
    {
        /// <summary>
        /// Gets the string contents of an embedded shader file. Make sure a shader file you add is named
        /// either .frag or .vert and that you set the build action under properties to embedded resource.
        /// </summary>
        /// <param name="filename">The filename of the embedded resource.</param>
        /// <returns></returns>
        public static void GetEmbeddedShaderFile(string filename, out string contents)
        {
            contents = string.Empty;

            var assembly = Assembly.GetExecutingAssembly();

            string[] files = assembly.GetManifestResourceNames();

            // search all files in the assembly. 
            foreach (string s in files)
            {
                // if we've found the resource file we are looking for.
                if (s.Contains(filename))
                {
                    using (Stream stream = assembly.GetManifestResourceStream(s))
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            contents = reader.ReadToEnd();
                        }
                    }

                    // break out of loop
                    break;
                }
            }


        }


    }

}


using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace GLES
{
    /// <summary>
    /// Embedded resource helper
    /// </summary>
    public class EmbeddedResourceHelper
    {

        /// <summary>
        /// Gets the string contents of an embedded file. E.g. Make sure a shader file you add is named
        /// either .frag or .vert and that you set the build action under properties to embedded resource.
        /// </summary>
        /// <param name="filename">The filename of the embedded resource.</param>
        /// <returns></returns>
        public static void GetEmbeddedFileAsString(Assembly assembly, string filename, out string contents)
        {
            contents = string.Empty;

            byte[] data;
            GetEmbeddedFileAsBytes(assembly, filename, out data);

            // use stream reader to convert bytes to string as this checks the various string encodings for us.
            using (MemoryStream ms = new MemoryStream(data))
            {
                using (StreamReader sr = new StreamReader(ms))
                {
                    contents = sr.ReadToEnd();
                }
            }

        }


        /// <summary>
        /// Gets the string contents of an embedded file. 
        /// <returns></returns>
        public static void GetEmbeddedFileAsBytes(Assembly assembly, string filename, out byte[] contents)
        {
            contents = new byte[0];

            // input guard
            if (assembly == null || string.IsNullOrEmpty(filename)) 
            { 
                throw new ArgumentException();
            }

            string[] files = assembly.GetManifestResourceNames();

            // search all files in the assembly. 
            foreach (string s in files)
            {
                // if we've found the resource file we are looking for.
                if (s.Contains(filename))
                {
                    using (Stream stream = assembly.GetManifestResourceStream(s))
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            stream.CopyTo(ms);
                            contents =  ms.ToArray();
                        }                     
                    }

                    // break out of loop
                    break;
                }
            }
        }
    }
}

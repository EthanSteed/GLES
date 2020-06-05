
using System;
using System.Collections.Generic;
using System.Reflection;
using GLES.Demo._04_Texture;

namespace GLES.Demo
{
    /// <summary>
    /// DemoFactory - Create the required demo.
    /// </summary>
    public static class DemoFactory
    {

        /// <summary>
        /// Gets the required demo
        /// </summary>
        public static IDemo GetDemo(int num)
        {
            IDemo demo = null;
            
            var assembly = Assembly.GetExecutingAssembly();

            // use reflection to find all classes tagged with DemoAttribute            
            foreach (Type t in assembly.GetTypes())
            {
                var att = t.GetCustomAttribute<DemoAttribute>();

                if (att != null && att.Id == num)
                {
                    demo = Activator.CreateInstance(t) as IDemo;
                    break;
                }
            }

            // if we haven't found the demo class with the id we want then just
            // default to first demo.
            if (demo == null)
            {
                demo = new TriangleDemo();
            }

            return demo;
        }





    }
}


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

            // return the required demo.
            switch (num)
            {
                case 1:
                    demo = new Demo01Triangle();
                    break;
                case 2:
                    demo = new Demo02Line();
                    break;
                case 3:
                    demo = new Demo03Viewports();
                    break;
                default:
                    demo = new Demo01Triangle();
                    break;
            }

            return demo;
        }

    }
}

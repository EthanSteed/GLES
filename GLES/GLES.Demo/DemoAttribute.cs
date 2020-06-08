using System;
using System.Collections.Generic;
using System.Text;

namespace GLES.Demo
{
    /// <summary>
    /// Demo Attribute 
    /// </summary>
    public class DemoAttribute : Attribute
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public DemoAttribute(char id, string description)
        {
            Id = id;
            Description = description;
        }

            /// <summary>
        /// the id for this demo
        /// </summary>
        public char Id { get; set; }

        /// <summary>
        /// Description of this demo
        /// </summary>
        public string Description { get; set; }

    }
}

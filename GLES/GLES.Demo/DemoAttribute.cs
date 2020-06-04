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
        public DemoAttribute(int id, string description)
        {
            Id = id;
            Description = description;
        }

        /// <summary>
        /// ID for this demo
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Description of this demo
        /// </summary>
        public string Description { get; set; }

    }
}

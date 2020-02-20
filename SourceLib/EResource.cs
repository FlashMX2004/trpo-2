using System;
using System.Diagnostics;

namespace SourceLib
{
    /// <summary>
    /// Class of e-resources
    /// </summary>
    public class EResource : Source
    {
        /// <summary>
        /// E-resource link
        /// </summary>
        public string Link { get; set; }
        /// <summary>
        /// E-resource annotation
        /// </summary>
        public string Annotation { get; set; }
        /// <summary>
        /// Displays all e-resource properties
        /// </summary>
        public override void Display()
        {
            Console.WriteLine("--EResource--\nName: " + Name + DISPLAY_SEPARATOR +
                              "Author: " + Author + DISPLAY_SEPARATOR +
                              "Link: " + Link + DISPLAY_SEPARATOR +
                              "Annotation: " + Annotation + "\n");
            Trace.WriteLine("Display method of e-resource was called");
        }
    }
}

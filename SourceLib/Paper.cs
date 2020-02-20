using System;
using System.Diagnostics;

namespace SourceLib
{
    /// <summary>
    /// Class of papers
    /// </summary>
    public class Paper : Source
    {
        /// <summary>
        /// Name of paper
        /// </summary>
        public string PaperName { get; set; }
        /// <summary>
        /// Number of paper
        /// </summary>
        public int PaperNumber { get; set; }
        /// <summary>
        /// Paper publish year
        /// </summary>
        public string PublishYear { get; set; }
        /// <summary>
        /// Displays all paper properties
        /// </summary>
        public override void Display()
        {
            Console.WriteLine("--Paper--\nName: " + Name + DISPLAY_SEPARATOR +
                              "Author: " + Author + DISPLAY_SEPARATOR +
                              "Paper name: " + PaperName + DISPLAY_SEPARATOR +
                              "Paper number: " + PaperNumber + DISPLAY_SEPARATOR +
                              "Publish year: " + PublishYear + "\n");
            Trace.WriteLine("Display method of paper was called");
        }
    }
}

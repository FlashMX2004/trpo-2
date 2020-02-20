using System;
using System.Diagnostics;

namespace SourceLib
{
    /// <summary>
    /// Class of books
    /// </summary>
    public class Book : Source
    {
        /// <summary>
        /// Book publisher
        /// </summary>
        public string Publisher { get; set; }
        /// <summary>
        /// Book publish year
        /// </summary>
        public string PublishYear { get; set; }
        /// <summary>
        /// Displays all book properties
        /// </summary>
        public override void Display()
        {
            Console.WriteLine("--Book--\nName: " + Name + DISPLAY_SEPARATOR +
                              "Author: " + Author + DISPLAY_SEPARATOR +
                              "Publish year: " + PublishYear + DISPLAY_SEPARATOR +
                              "Publisher: " + Publisher + "\n");
            Trace.WriteLine("Display method of book was called");
        }
    }
}

using System;
using System.Linq;
using SourceLib;

namespace OOPConsoleApp
{
    internal class Program
    {
        /// <summary>
        /// Name of file to read sources
        /// </summary>
        private const string READ_FILE_NAME = "input.txt";
        /// <summary>
        /// Name of file to write sources
        /// </summary>
        private const string WRITE_FILE_NAME = "output.xml";

        private static void Main(string[] args)
        {
            Source[] sources = FileManager.ReadFromFile(READ_FILE_NAME);
                               FileManager.WriteToXML(WRITE_FILE_NAME, sources);
            foreach (Source source in sources) source.Display();
            while (Search(sources)) ;
        }

        /// <summary>
        /// Searches sources by author and displays result
        /// </summary>
        /// <param name="sources">Sources</param>
        /// <returns>False, if user write n</returns>
        private static bool Search(Source[] sources)
        {
            Console.Write("Enter author (n for exit): ");
            string author = Console.ReadLine();

            if (author != "n")
            {
                Console.WriteLine("\nSearch results: ");
                foreach (Source source in sources.Where(s => s.Author == author))
                {
                    source.Display();
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
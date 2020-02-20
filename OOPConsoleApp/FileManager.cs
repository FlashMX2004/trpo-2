using System.IO;
using System.Text;
using System.Xml.Serialization;
using SourceLib;

namespace OOPConsoleApp
{
    /// <summary>
    /// Manager to work with file data
    /// </summary>
    public static class FileManager
    {
        /// <summary>
        /// Book source string
        /// </summary>
        private const string BOOK = "Book";
        /// <summary>
        /// Paper source string
        /// </summary>
        private const string PAPER = "Paper";
        /// <summary>
        /// E-resource source string
        /// </summary>
        private const string ERESOURCE = "EResource";
        /// <summary>
        /// Xml serializer, that serializes source array
        /// </summary>
        private static readonly XmlSerializer xml = new XmlSerializer(typeof(Source[]));

        /// <summary>
        /// Reads sources from file with path
        /// </summary>
        /// <param name="path">Path of the file</param>
        /// <returns>String from file</returns>
        public static Source[] ReadFromFile(string path)
        {
            int length, counter = 0;
            Source[] result;
            Source current;

            using var reader = new StreamReader(path, Encoding.Default);

            // Read length and create array
            length = int.Parse(reader.ReadLine());
            result = new Source[length];

            // Read all sources from file by stream reader
            while ((current = ReadSource(reader)) != null) result[counter++] = current;
            
            return result;
        }
        /// <summary>
        /// Saves sources into xml file
        /// </summary>
        /// <param name="path">Path to file or file name</param>
        /// <param name="sources">Sources to save</param>
        public static void WriteToXML(string path, Source[] sources)
        {
            using FileStream stream = new FileStream(path, FileMode.Create);
            xml.Serialize(stream, sources);
        }
        /// <summary>
        /// Reads next source from file by stream reader
        /// </summary>
        /// <param name="reader">Stream reader</param>
        /// <returns>Read source from file</returns>
        private static Source ReadSource(StreamReader reader) => reader.ReadLine() switch
        {
            BOOK => new Book
            {
                Name = reader.ReadLine(),
                Author = reader.ReadLine(),
                Publisher = reader.ReadLine(),
                PublishYear = reader.ReadLine()
            },
            PAPER => new Paper
            {
                Name = reader.ReadLine(),
                Author = reader.ReadLine(),
                PaperName = reader.ReadLine(),
                PaperNumber = int.Parse(reader.ReadLine()),
                PublishYear = reader.ReadLine()
            },
            ERESOURCE => new EResource
            {
                Name = reader.ReadLine(),
                Author = reader.ReadLine(),
                Link = reader.ReadLine(),
                Annotation = reader.ReadLine()
            },

            _ => null
        };
    }
}

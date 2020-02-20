namespace SourceLib
{
    /// <summary>
    /// Base class for readable objects
    /// </summary>
    [System.Xml.Serialization.XmlInclude(typeof(Book))]
    [System.Xml.Serialization.XmlInclude(typeof(Paper))]
    [System.Xml.Serialization.XmlInclude(typeof(EResource))]
    public abstract class Source
    {
        /// <summary>
        /// Display separator
        /// </summary>
        protected const string DISPLAY_SEPARATOR = ",\n";

        /// <summary>
        /// Name of source
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// Displays all source properties
        /// </summary>
        public abstract void Display();
        /// <summary>
        /// Check for equality of source and other object
        /// </summary>
        /// <param name="other">An object to check</param>
        /// <returns>True, if objects are equal</returns>
        public override bool Equals(object other) => other is Source ? Name == (other as Source).Name && Author == (other as Source).Author : false;
        /// <summary>
        /// Returns hash code of source
        /// </summary>
        /// <returns>Hash code of source</returns>
        public override int GetHashCode() => Name.GetHashCode() ^ Author.GetHashCode();
        public static bool operator ==(Source source1, Source source2) => (source1 as object) == null || (source2 as object) == null ? Equals(source1, source2) : source1.Equals(source2);
        public static bool operator !=(Source source1, Source source2) => (source1 as object) == null || (source2 as object) == null ? !Equals(source1, source2) : !source1.Equals(source2);
    }
}
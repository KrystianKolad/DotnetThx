using System.Xml.Serialization;

namespace DotnetThx.Models
{
    public class PackageReference
    {
        [XmlAttribute]
        public string Include { get; set; }
    }
}
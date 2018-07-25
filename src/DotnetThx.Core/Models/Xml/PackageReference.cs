using System.Xml.Serialization;

namespace DotnetThx.Core.Models.Xml
{
    public class PackageReference
    {
        [XmlAttribute]
        public string Include { get; set; }
    }
}
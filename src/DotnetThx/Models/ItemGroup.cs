using System.Collections.Generic;
using System.Xml.Serialization;

namespace DotnetThx.Models
{
    public class ItemGroup
    {
        [XmlElement]
        public List<PackageReference> PackageReference { get; set; }
    }
}
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DotnetThx.Core.Models.Xml
{
    public class ItemGroup
    {
        [XmlElement]
        public List<PackageReference> PackageReference { get; set; }
    }
}
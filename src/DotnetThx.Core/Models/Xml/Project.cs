using System.Collections.Generic;
using System.Xml.Serialization;

namespace DotnetThx.Core.Models.Xml
{
    [XmlRoot]
    public class Project
    {
        [XmlElement]
        public List<ItemGroup> ItemGroup { get; set; }
    }
}
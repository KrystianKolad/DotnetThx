using System.Collections.Generic;
using System.Xml.Serialization;

namespace DotnetThx.Models
{
    [XmlRoot]
    public class Project
    {
        [XmlElement]
        public List<PropertyGroup> PropertyGroup { get; set; }
        [XmlElement]
        public List<ItemGroup> ItemGroup { get; set; }
    }
}
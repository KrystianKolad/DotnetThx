using System.IO;
using DotnetThx.Core.Models.Xml;
using DotnetThx.Core.Services.Interfaces;

namespace DotnetThx.Core.Services
{
    public class XmlSerializer : IXmlSerializer
    {
        public Project Deserialize(FileStream stream)
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Project));
            return (Project)serializer.Deserialize(stream);
        }
    }
}
using System.IO;
using System.Xml.Serialization;
using DotnetThx.Models;

namespace DotnetThx
{
    public static class ProjectDeserializer
    {
        public static Project Deserialize(FileStream stream)
        {
            var serializer = new XmlSerializer(typeof(Project));
            return (Project)serializer.Deserialize(stream);
        }
    }
}
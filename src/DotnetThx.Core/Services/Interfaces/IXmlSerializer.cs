using System.IO;
using DotnetThx.Core.Models.Xml;

namespace DotnetThx.Core.Services.Interfaces
{
    public interface IXmlSerializer
    {
        Project Deserialize(FileStream stream);
    }
}
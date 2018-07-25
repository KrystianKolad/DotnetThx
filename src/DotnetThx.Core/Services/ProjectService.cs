using System.Collections.Generic;
using System.IO;
using DotnetThx.Core.Models.Xml;
using DotnetThx.Core.Services.Interfaces;

namespace DotnetThx.Core.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IFileService _fileService;
        private readonly IXmlSerializer _xmlSerializer;

        public ProjectService(IFileService fileService,IXmlSerializer xmlSerializer)
        {
            _fileService = fileService;
            _xmlSerializer = xmlSerializer;
        }

        public IList<Project> FindProjects()
        {
            IList<Project> projects = new List<Project>();
            foreach(var item in _fileService.FindFiles())
            {
                using (var stream = new FileStream(item,FileMode.Open))
                {
                    projects.Add(_xmlSerializer.Deserialize(stream));
                }
            }
            return projects;
        }
    }
}
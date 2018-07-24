using System.Collections.Generic;
using System.IO;
using DotnetThx.Models;

namespace DotnetThx
{
    public static class ProjectsSearcher
    {
        public static List<Project> GetProjects()
        {
            List<Project> projects = new List<Project>();
            foreach(var item in FileSearcher.FindAllFiles())
            {
                using (var stream = new FileStream(item,FileMode.Open))
                {
                    projects.Add(ProjectDeserializer.Deserialize(stream));
                }
            }
            return projects;
        }
    }
}
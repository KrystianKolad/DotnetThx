using System.Collections.Generic;
using DotnetThx.Core.Models.Xml;

namespace DotnetThx.Core.Services.Interfaces
{
    public interface IProjectService
    {
        IList<Project> FindProjects();
    }
}
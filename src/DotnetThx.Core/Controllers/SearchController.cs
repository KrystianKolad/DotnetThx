using System.Collections.Generic;
using System.Threading.Tasks;
using DotnetThx.Core.Controllers.Interfaces;
using DotnetThx.Core.Models.Json;
using DotnetThx.Core.Models.Xml;
using DotnetThx.Core.Services.Interfaces;

namespace DotnetThx.Core.Controllers
{
    public class SearchController : ISearchController
    {
        private readonly IProjectService _projectService;
        private readonly IPackageService _packageService;

        public SearchController(IProjectService projectService, IPackageService packageService)
        {
            _projectService = projectService;
            _packageService = packageService;
        }
        public async Task<IList<Package>> InvokeSearch()
        {
            var projects = _projectService.FindProjects();
            var packages = _packageService.FindPackages(projects);
            var result = await _packageService.GetPackages(packages);
            return result;
        }
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using DotnetThx.Core.Models.Json;
using DotnetThx.Core.Models.Xml;
using DotnetThx.Core.Services.Interfaces;

namespace DotnetThx.Core.Services
{
    public class PackageService : IPackageService
    {
        private readonly INugetService _nugetService;
        public PackageService(INugetService nugetService)
        {
            _nugetService = nugetService;
        }
        public IList<string> FindPackages(IList<Project> projects)
        {
            {
                var result = new List<string>();
                foreach (var project in projects)
                {
                    foreach (var itemGroup in project.ItemGroup)
                    {
                        foreach (var packageReference in itemGroup.PackageReference)
                        {
                            result.Add(packageReference.Include);
                        }
                    }
                }
                return result;
            }
        }

        public async Task<IList<Package>> GetPackages(IList<string> packagesNames)
        {
            var nugetResponses = new List<NugetResponse>();
            foreach (var packageName in packagesNames)
            {
                nugetResponses.Add(await _nugetService.Get(packageName));
            }

            var result = new List<Package>();
            foreach (var response in nugetResponses)
            {
                result.AddRange(response.data);
            }

            return result;
        }
    }
}
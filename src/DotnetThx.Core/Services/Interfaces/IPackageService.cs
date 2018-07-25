using System.Collections.Generic;
using System.Threading.Tasks;
using DotnetThx.Core.Models.Json;
using DotnetThx.Core.Models.Xml;

namespace DotnetThx.Core.Services.Interfaces
{
    public interface IPackageService
    {
        IList<string> FindPackages(IList<Project> projects);

        Task<IList<Package>> GetPackages(IList<string> packagesNames);
    }
}
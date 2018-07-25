using System.Collections.Generic;
using System.Threading.Tasks;
using DotnetThx.Core.Models.Json;

namespace DotnetThx.Core.Controllers.Interfaces
{
    public interface ISearchController
    {
        Task<IList<Package>> InvokeSearch();
    }
}
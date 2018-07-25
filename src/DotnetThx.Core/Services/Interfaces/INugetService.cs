using System.Threading.Tasks;
using DotnetThx.Core.Models.Json;
using RestEase;

namespace DotnetThx.Core.Services.Interfaces
{
    [SerializationMethods(Query = QuerySerializationMethod.Serialized)]
    public interface INugetService
    {
        [AllowAnyStatusCode]
        [Get("query?q={name}")]
        Task<NugetResponse> Get([Path]string name);
    }
}
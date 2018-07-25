using System.Collections.Generic;

namespace DotnetThx.Core.Services.Interfaces
{
    public interface IFileService
    {
        IList<string> FindFiles();
    }
}
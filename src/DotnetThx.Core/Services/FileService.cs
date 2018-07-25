using System.Collections.Generic;
using System.IO;
using System.Linq;
using DotnetThx.Core.Services.Interfaces;

namespace DotnetThx.Core.Services
{
    public class FileService : IFileService
    {
        public IList<string> FindFiles()
        {
            return Directory.GetFiles(".","*.*proj",SearchOption.AllDirectories).ToList();
        }
    }
}
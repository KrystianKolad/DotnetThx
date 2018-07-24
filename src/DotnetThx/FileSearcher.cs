using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DotnetThx
{
    public static class FileSearcher
    {
        public static List<string> FindAllFiles()
        {
            return Directory.GetFiles(".","*.*proj",SearchOption.AllDirectories).ToList();
        }
    }
}
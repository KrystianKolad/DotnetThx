using System.Collections.Generic;
using DotnetThx.Models;

namespace DotnetThx
{
    public static class PackageSearcher
    {
        public static List<string> FindPackages(List<Project> projects)
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
}
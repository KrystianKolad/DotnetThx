using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using DotnetThx.Models;

namespace DotnetThx
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Package> packages = new List<Package>();
            foreach (var item in PackageSearcher.FindPackages(ProjectsSearcher.GetProjects()))
            {
                packages.AddRange(NugetApiClient.GetPackagesAsync(item).Result);
            }
        }
    }
}

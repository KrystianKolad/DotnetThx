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
            foreach (var item in PackageSearcher.FindPackages(ProjectsSearcher.GetProjects()))
            {
                System.Console.WriteLine(item);
            }
        }
    }
}

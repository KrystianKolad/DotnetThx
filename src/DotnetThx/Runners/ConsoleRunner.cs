using System;
using DotnetThx.Core.Controllers.Interfaces;
using DotnetThx.Runners.Interfaces;

namespace DotnetThx.Runners
{
    public class ConsoleRunner : IConsoleRunner
    {
        private readonly ISearchController _searchController;
        public ConsoleRunner(ISearchController searchController)
        {
            _searchController = searchController;
        }
        public void Run()
        {
            var searchResult = _searchController.InvokeSearch().Result;
            Console.WriteLine("List of people you should thank for:");
            foreach (var item in searchResult)
            {
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine($"Package:{item.Id}");
                Console.WriteLine($"Page:{item.ProjectUrl}");
                foreach (var author in item.Authors)
                {
                    Console.WriteLine(author);
                }
                Console.WriteLine("---------------------------------------------------------------");
            }
        }
    }
}
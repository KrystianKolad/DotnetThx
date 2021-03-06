using System;
using DotnetThx.Core.Controllers;
using DotnetThx.Core.Controllers.Interfaces;
using DotnetThx.Core.Services;
using DotnetThx.Core.Services.Interfaces;
using DotnetThx.Runners;
using DotnetThx.Runners.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using RestEase;

namespace DotnetThx.Bootstrappers
{
    public class Bootstrapper
    {
        private IRunner _runner;
        private static readonly IServiceProvider _serviceProvider;
        static Bootstrapper()
        {
            _serviceProvider = new ServiceCollection()
                .AddScoped<IRunner, ConsoleRunner>()
                .AddScoped<ISearchController,SearchController>()
                .AddScoped<IFileService, FileService>()
                .AddScoped<INugetService>(obj => RestClient.For<INugetService>("https://api-v2v3search-0.nuget.org"))
                .AddScoped<IPackageService, PackageService>()
                .AddScoped<IProjectService,ProjectService>()
                .AddScoped<IXmlSerializer,XmlSerializer>()
                .BuildServiceProvider();
        }

        public void Start()
        {
            _runner = _serviceProvider.GetService<IRunner>();
            _runner.Run();
        }
    }
}
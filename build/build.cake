var target = Argument("target", "Default");
var releaseConfiguration = Argument("Configuration", "Release");
var debugConfiguration = Argument("Configuration", "Debug");
var solution = "../DotnetThx.sln";
var artifacts = "../artifacts/";
var packages = "../packages/";
var pack = "../pack/";

Task("Clean")
  .Does(() =>
  {
    var directorySettings = new DeleteDirectorySettings {
      Recursive = true,
      Force = true
    };
    if (DirectoryExists(artifacts))
    {
        DeleteDirectory(artifacts, directorySettings);
    }
    if (DirectoryExists(packages))
    {
        DeleteDirectory(packages, directorySettings);
    }
  });

Task("Restore")
  .IsDependentOn("Clean")
  .Does(() =>
  {
    DotNetCoreRestore(solution);
  });

Task("Build")
  .IsDependentOn("Restore")
  .Does(() =>
  {
    DotNetCoreBuild(solution);
  });

Task("Test")
  .IsDependentOn("Build")
  .Does(() =>
  {
    var projects = GetFiles("../tests/**/*.csproj");
    foreach(var project in projects)
    {
        DotNetCoreTest(
            project.ToString(),
            new DotNetCoreTestSettings()
            {
                Configuration = debugConfiguration,
                NoBuild = true,
                ArgumentCustomization = args => args.Append("--no-restore"),
            });
    }
  });

Task("Publish")
  .IsDependentOn("Test")
  .Does(() =>
  {
    DotNetCorePublish(
              "../src/DotnetThx/DotnetThx.csproj",
              new DotNetCorePublishSettings()
              {
                  Configuration = releaseConfiguration,
                  OutputDirectory = artifacts,
                  ArgumentCustomization = args => args.Append("--no-restore"),
              });
  });

Task("Pack")
  .IsDependentOn("Publish")
  .Does(() =>
  {
    DotNetCorePack(
      "../src/DotnetThx/DotnetThx.csproj",
      new DotNetCorePackSettings()
      {
          Configuration = releaseConfiguration,
          OutputDirectory = pack,
          ArgumentCustomization = args => args.Append("--no-restore"),
      });
  });

Task("Default")
  .IsDependentOn("Pack")
  .Does(() =>{ });



RunTarget(target);

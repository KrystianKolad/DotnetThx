using System;
using DotnetThx.Bootstrappers;

namespace DotnetThx
{
    class Program
    {
        static void Main(string[] args)
        {
            var bootstrapper = new Bootstrapper();
            bootstrapper.Start();
        }
    }
}

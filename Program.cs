using System;
using System.IO;

namespace jamsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var siteConfigSourcePath = args.Length >= 1 ? args[0] : Path.Combine(Directory.GetCurrentDirectory(), "jamstack.json");
            Console.WriteLine(siteConfigSourcePath);
        }
    }
}

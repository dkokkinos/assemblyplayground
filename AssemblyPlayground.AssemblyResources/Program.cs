using Math.Core;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace AssemblyPlayground.AssemblyResources
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var assembly = typeof(Calculator).Assembly; // Get the assembly that contains the resources

            // Math.Core is the namespace in the Math.Core assembly.
            // The 2048x1536-dark-moon_1574942953.jpg is under the directory Resources
            // Access the directly embedded resources using the GetManifestResourceStream
            using Stream s = assembly.GetManifestResourceStream("Math.Core.Resources.2048x1536-dark-moon_1574942953.jpg");
            var image = Image.FromStream(s);
            Console.WriteLine($"Image[read using GetManifestResourceStream] dark-moon:{image.Size}");

            ResourceManager rm = new ResourceManager("Math.Core.Properties.Resources", assembly);
            var darkMoonBytes = (byte[])rm.GetObject("2048x1536-dark-moon_1574942953");
            using var ms = new MemoryStream(darkMoonBytes);
            image = Image.FromStream(ms);
            Console.WriteLine($"Image[read using ResourceManager] dark-moon:{image.Size}");

            // Access string resources using the ResourceManager
            var resource1 = rm.GetString("Resource1");
            var resource2 = rm.GetString("Resource2");
            Console.WriteLine($"Resource1:{resource1}, Resource2:{resource2}");

            // enumerate all available resources
            ResourceSet resourceSet = rm.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            foreach (System.Collections.DictionaryEntry entry in resourceSet)
                Console.WriteLine(entry.Key);

        }
    }
}
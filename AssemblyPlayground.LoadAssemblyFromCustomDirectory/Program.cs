using System.Reflection;

namespace AssemblyPlayground.LoadAssemblyFromCustomDirectory
{
    internal class Program
    {

        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyLoad;

            // This assembly is loaded only because we loaded from an external directory explicitly by using the CurrentDomain_AssemblyLoad event handler.
            var assembly = Assembly.Load("Math.Core");

            AppDomain.CurrentDomain.AssemblyResolve -= CurrentDomain_AssemblyLoad;

            string namespaceName = "Math.Core";
            string className = "Calculator";
            // Using reflection we can invoke the Add method of the Calculator object inside the Math.Core.dll assembly.
            var instance = assembly.CreateInstance($"{namespaceName}.{className}");
            var method = instance.GetType().GetMethod("Add");
            var res = method.Invoke(instance, new object[] { 1, 2 }); // res = 3
        }

        // This event will fire only when an assembly can not be resolved.
        private static Assembly? CurrentDomain_AssemblyLoad(object? sender, ResolveEventArgs args)
        {
            // This directory contains the assembly to be loaded Math.Core.dll
            string baseUrl = Path.Combine( Directory.GetCurrentDirectory(),"..\\..\\..\\..\\Math.Core\\bin\\Debug\\net7.0\\");
            var assemblyName = new AssemblyName(args.Name);
            var assemblyExternalLocation = Path.Combine(baseUrl, $"{assemblyName.Name}.dll");

            // Load file does an assembly loading, not resolving, so the event will not fire again.
            return Assembly.LoadFile(assemblyExternalLocation);
        }
    }
}
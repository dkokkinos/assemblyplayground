using AdvancedMath;
using Math.Core;
using System.Reflection;

namespace AssemblyReflectionConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mathAdvancedAssembly = typeof(AdvancedCalculator).Assembly; // Gets the assembly of the Math.Advanced library
            // Math.Advanced, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9a6e2ec23b9a60ea


            var mathCoreAssembly = typeof(Calculator).Assembly; // Gets the assembly of the Math.Core library
            // Math.Core, Version=1.0.0.1, Culture=neutral, PublicKeyToken=9a6e2ec23b9a60ea

            // For the assemblies to have PublicKeyToken they must be signed. This also gives them a strong name.


            var executingAssembly = Assembly.GetExecutingAssembly();

        }
    }
}
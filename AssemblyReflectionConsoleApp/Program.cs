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

            var executingAssembly = Assembly.GetExecutingAssembly();

            string fullName = mathAdvancedAssembly.FullName; // the fully qualified name Math.Advanced, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9a6e2ec23b9a60ea
            AssemblyName assemblyName = mathAdvancedAssembly.GetName(); // The fully qualified as AssemblyName object.
            var simpleName = assemblyName.Name; // Math.Advanced
            var fullyQualifiedName = assemblyName.FullName; // Math.Advanced, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9a6e2ec23b9a60ea
            var version = assemblyName.Version; // 2.0.0.0
            var cultureInfo = assemblyName.CultureInfo; // if not a satellite assembly => empty.
            var publicKey = assemblyName.GetPublicKey();
            string publicKeyAsString = string.Empty;
            for (int i = 0; i < publicKey.GetLength(0); i++)
                publicKeyAsString += string.Format("{0:x2}", publicKey[i]);

            var publicKeyToken = assemblyName.GetPublicKeyToken(); // 9a6e2ec23b9a60ea
            string publicKeyTokenAsString = string.Empty; // 9a6e2ec23b9a60ea
            for (int i = 0; i < publicKeyToken.GetLength(0); i++)
                publicKeyTokenAsString += string.Format("{0:x2}", publicKeyToken[i]);

            var location = mathAdvancedAssembly.Location; // The location of the Assembly file.

            // This operation performs an assembly resolution because the location of the assembly must be found from its simple name
            var loadedAssembly = Assembly.Load("Math.Advanced");

            // Same as the previous operation, this time providing the full name of the assembly.
            var loadedAssemblyWithFullName = Assembly.Load("Math.Advanced, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9a6e2ec23b9a60ea");

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyPlayGround.LoadAssemblyFromGAC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // We assume the Math.Core assembly is located in the GAC
            // To register an assembly to GAC run the following command
            // gacutil /i <your path>\assemblyplayground\Math.Core\bin\Debug\net461\Math.Core.dll

            // To check whether or not an assembly is present in the GAC run the following command
            // gacutil /l Math.Core

            var assemlyLoadedFromGAC = Assembly.Load("Math.Core");
            if(assemlyLoadedFromGAC == null)
                Console.WriteLine("Math.Core is not registered in GAC.");
            else
                Console.WriteLine("Math.Core is registered in GAC.");

            // To unregister the assembly from GAC run the following command
            // gacutil /u Math.Core
        }
    }
}

using AdvancedMath;
using Math.Core;
using System;
using System.Runtime.Loader;

namespace AssemblyPlaygroundConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var mathCoreClient = new MathCoreClient();
            mathCoreClient.Execute();

            var mathAdvancedClient = new MathAdvancedClient();
            mathAdvancedClient.Execute();

            Console.ReadKey();
        }

        public class MathCoreClient
        {
            public void Execute()
            {
                Calculator c = new Calculator();
                var res = c.Add(1, 1);
                Console.WriteLine(res);
            }
        }

        public class MathAdvancedClient
        {
            public void Execute()
            {
                AdvancedCalculator c = new AdvancedCalculator();
                var res = c.Eval("1+1");
                Console.WriteLine(res);
            }
        }
    }
}

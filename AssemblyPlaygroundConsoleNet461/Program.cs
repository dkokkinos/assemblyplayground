using AdvancedMath;
using System;

namespace AssemblyPlaygroundConsoleNet461
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdvancedCalculator calculator = new AdvancedCalculator();
            var res = calculator.Eval("1 + 1 - 2");
            Console.WriteLine(res);
        }
    }
}
using Math.Core;
using System;

namespace AssemblyPlaygroundConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            var res = c.Add(1, 1);
            Console.WriteLine(res);
        }
    }
}

using AdvancedMath;
using Newtonsoft.Json;
using System;

namespace AssemblyPlayground.BindingRedirectConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdvancedCalculator calculator = new AdvancedCalculator(); // AdvancedCalculator components exists in Math.Advanced assembly.
            var res = calculator.Eval("1+1"); // <- this line raises an exception because this causes the runtime to load the Newtosoft.Json v11.0.1 which
            // is references by the Math.Advanced assembly. However, the application also references the Newtonsoft.Json assembly but v13.0.1, so the runtime
            // cannot find the v11.0.1
            var objResult = JsonConvert.DeserializeObject(res);
            Console.WriteLine(objResult);

            Console.ReadKey();
        }
    }
}

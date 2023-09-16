
using Math.Core;
using Newtonsoft.Json;

namespace AdvancedMath
{
    public class AdvancedCalculator
    {
        public string Eval(string expression)
        {
            NCalc.Expression expr = new NCalc.Expression(expression);
            var res = expr.Evaluate();
            var jsonResult = JsonConvert.SerializeObject(new { result = res });
            return jsonResult;
        }

        public int Add(int x, int y)
        {
            Calculator calculator = new Calculator();
            return calculator.Add(x, y);
        }
    }
}
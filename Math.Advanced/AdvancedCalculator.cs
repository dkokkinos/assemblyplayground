
using Math.Core;

namespace AdvancedMath
{
    public class AdvancedCalculator
    {
        public object Eval(string expression)
        {
            NCalc.Expression expr = new NCalc.Expression(expression);
            var res = expr.Evaluate();
            return res;
        }

        public int Add(int x, int y)
        {
            Calculator calculator = new Calculator();
            return calculator.Add(x, y);
        }
    }
}
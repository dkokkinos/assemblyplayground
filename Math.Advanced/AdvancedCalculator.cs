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
    }
}
using System;

namespace Experiment
{
    public class RecursiveCalculator : Calculator
    {
        
        public int Add(int x, int y)
        {
            return 0;
        }

        public override double Power(double x, int y)
        {
            if (y == 0)
                return 1;
            else if (y < 0)
                return (1 / x) * Power(x, y + 1);
            else
                return x * Power(x, y - 1);
        }
    }
}

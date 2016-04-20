using System;

namespace Experiment
{
    public class LoopCalculator : Calculator
    {
        public override double Power(double x, int y)
        {
            double z = 1;
            int absY = y < 0 ? y * -1 : y;
            for(int i = 0; i < absY; i++)
            {
            	z *= x;
            }
            return y < 0 ? 1 / z : z;
        }
    }
}

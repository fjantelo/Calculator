using System;

namespace Experiment
{
	public abstract class Calculator : ICalculator
	{
		public int Add (int x, int y){
			return x+y;
		}

		public int Subtract (int x, int y){
			return x-y;
		}

		public int Multiply (int x, int y){
			return x*y;
		}

		public double Divide (double x, double y){
			if (y==0){
				throw new DivideByZeroException ();
			}
			return x/y;
		}

		public int Sqrt (int x){
			return 0;
		}

		public int Square (int x){
			return x*x;
		}

        public abstract double Power(double x, int y);
    }
}


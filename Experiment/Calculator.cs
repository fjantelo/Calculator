using System;

namespace Experiment
{
	public class Calculator
	{
		public Calculator ()
		{

		}

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

		public int Sqrt (){
			return 0;
		}

		public int Square (int x){
			return x*x;
		}

		public double Power(double x, int y){
			// First Approach
			/*double z=1;

			if (y < 0){
				for (int i = 0; i < y*-1; i++) {
					z = z / x;
				}
			}

			else {
				for (int i = 0; i < y; i++) {
					z = x * z;
				}
			}

			return z;*/

			// Second Approach
//
//			double z = 1;
//			int absY = y < 0 ? y * -1 : y;
//
//			for(int i = 0; i < absY; i++) {
//				z *= x;
//			}
//
//			return y < 0 ? 1 / z : z;

			// Third Approach
			return RecursivePower(x, y);
		}

		private double RecursivePower(double x, int y) {
			if (y == 0)
				return 1;
			else if (y < 0)
				return (1/x) * RecursivePower(x,y+1);
			else
				return x * RecursivePower (x, y - 1);
		}
	}
}


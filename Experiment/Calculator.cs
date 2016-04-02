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

		public int Square (){
			return 0;
		}
	}
}


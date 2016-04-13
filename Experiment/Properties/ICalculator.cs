using System;

namespace Experiment
{
	public interface ICalculator
	{
		int Add(int x, int y);
		int Subtract (int x, int y);
		int Multiply (int x, int y);
		double Divide (double x, double y);
		int Sqrt (int x);
		int Square (int x);
		double Power(double x, int y);
	}
}


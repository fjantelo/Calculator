using NUnit.Framework;
using System;
using Experiment;

namespace ExperimentTests
{
	[TestFixture (typeof(LoopCalculator))]
    [TestFixture(typeof(RecursiveCalculator))]
    public class Test<T> where T : ICalculator, new()
	{
		ICalculator test;                

		[SetUp]
		public void Setup() {
			test = new T();
		}

		[Test ()]
		public void TestAdd ()
		{
			Assert.AreEqual(12, test.Add (5, 7));
			Assert.AreEqual (60, test.Add (61,-1));            
		}

        [Test ()]
		public void TestSubtract (){
			Assert.AreEqual (5, test.Subtract (7,2)); 			
		}

		[Test ()]
		public void TestMultiply (){
			Assert.AreEqual (-9000, test.Multiply (-1, 9000));
		}

		[Test ()]
		public void TestDivide (){
			Assert.AreEqual (2, test.Divide(10,5));
			Assert.Throws<DivideByZeroException> (() => { test.Divide(5,0); });
		}

		[Test()]
		public void TestSquare (){
			Assert.AreEqual (25, test.Square (5));
		}

		[Test()]
		public void TestPower (){
			Assert.AreEqual (4, test.Power (2, 2));
			Assert.AreEqual (8, test.Power (2, 3));
			Assert.AreEqual (1, test.Power (69, 0));
			Assert.AreEqual (0.25, test.Power (2, -2));
		}
	}
}


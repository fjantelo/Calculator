using NUnit.Framework;
using System;
using Experiment;

namespace ExperimentTests
{
	[TestFixture ()]
	public class Test
	{
		Calculator test;

		[SetUp]
		public void Setup() {
			test = new Calculator ();
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
	}
}


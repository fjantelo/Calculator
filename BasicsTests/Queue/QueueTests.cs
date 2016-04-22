using System;
using NUnit.Framework;
using Basics.Queue;

namespace BasicsTests
{
    /// <summary>
    /// To only test on particular class, comment out the other class.
    /// For example, if you only want to test ArrayQueue, comment out:
    /// [TestFixture(typeof(ObjectQueue))]
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [TestFixture(typeof(ArrayQueue))]
    [TestFixture(typeof(ObjectQueue))]
    public class QueueTests<T> where T : IQueue, new()
    {
        IQueue test;

        [SetUp]
        public void Setup()
        {
            test = new T();
        }

        #region PopTests

        /// <summary>
        /// If the Queue is empty and you call Pop(), you should throw a
        /// InvalidArgumentException
        /// </summary>
        [Test()]
        public void PopTest1()
        {
            Assert.Throws<InvalidOperationException>(() => { test.Pop(); });
        }

        #endregion

        #region PeekTests

        /// <summary>
        /// If the Queue is empty and you call Peek, you should throw a
        /// InvalidArgumentException
        /// </summary>
        [Test()]
        public void PeekTest1()
        {
            Assert.Throws<InvalidOperationException>(() => { test.Peek(); });
        }

        #endregion

        #region Tests

        /// <summary>
        /// Basic Test. If the following are pushed into the stack in order:
        /// 1 2 3 4 5 6
        /// Then the following should be popped off the stack in the below order:
        /// 1 2 3 4 5 6
        /// </summary>
        [Test()]
        public void StackTest1()
        {
            test.Push(1);
            test.Push(2);
            test.Push(3);
            test.Push(4);
            test.Push(5);
            test.Push(6);

            Assert.AreEqual(6, test.Size());

            Assert.AreEqual(1, test.Pop());
            Assert.AreEqual(2, test.Pop());
            Assert.AreEqual(3, test.Pop());
            Assert.AreEqual(4, test.Pop());
            Assert.AreEqual(5, test.Pop());
            Assert.AreEqual(6, test.Pop());

            Assert.AreEqual(0, test.Size());
        }

        /// <summary>
        /// Basic Test. If the following are pushed into the queue in order:
        /// 5 -1 1 3 -8 10 6 11 11
        /// Then the following should be popped off the stack in the below order:
        /// 5 -1 1 3 -8 10 6 11 11
        /// </summary>
        [Test()]
        public void StackTest2()
        {
            test.Push(5);
            test.Push(-1);
            test.Push(1);
            test.Push(3);
            test.Push(-8);
            test.Push(10);
            test.Push(6);
            test.Push(11);
            test.Push(11);

            Assert.AreEqual(9, test.Size());

            Assert.AreEqual(5, test.Peek());
            Assert.AreEqual(5, test.Pop());
            Assert.AreEqual(-1, test.Peek());
            Assert.AreEqual(-1, test.Pop());
            Assert.AreEqual(1, test.Peek());
            Assert.AreEqual(1, test.Pop());
            Assert.AreEqual(3, test.Peek());
            Assert.AreEqual(3, test.Pop());
            Assert.AreEqual(-8, test.Peek());
            Assert.AreEqual(-8, test.Pop());
            Assert.AreEqual(10, test.Peek());
            Assert.AreEqual(10, test.Pop());
            Assert.AreEqual(6, test.Peek());
            Assert.AreEqual(6, test.Pop());
            Assert.AreEqual(11, test.Peek());
            Assert.AreEqual(11, test.Pop());
            Assert.AreEqual(11, test.Peek());
            Assert.AreEqual(11, test.Pop());            

            Assert.AreEqual(0, test.Size());
        }

        #endregion
    }
}

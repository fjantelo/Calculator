using System;

namespace Basics.Queue
{
    /// <summary>
    /// ObjectQueue is a Queue that uses an object(s) to maintain the list of elements in
    /// Queue. 
    /// <remarks>
    /// This Queue is a FILO Queue (First in Last Out). That means that the order 
    /// in which elements are Popped out of the queue follows the REVERSED order 
    /// in which elements were inserted into the Queue. See tests (or google) to 
    /// get a better understanding of the expected behavior of a Queue.
    /// </summary>
    public class ObjectQueue : IQueue
    {
        public int Peek()
        {
            throw new NotImplementedException();
        }

        public int Pop()
        {
            throw new NotImplementedException();
        }

        public void Push(int value)
        {
            throw new NotImplementedException();
        }

        public int Size()
        {
            throw new NotImplementedException();
        }
    }
}
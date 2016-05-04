using System;

namespace Basics.Queue
{
    /// <summary>
    /// ArrayQueue is a Queue that uses an array to maintain the list of elements in
    /// Queue. 
    /// <remarks>
    /// This Queue is a FIFO Queue (First in First out). That means that the order 
    /// in which elements are Popped out of the queue follows the order in which
    /// elements were inserted into the Queue. See tests (or google) to get a 
    /// better understanding of the expected behavior of a Queue.
    /// </remarks>
    /// </summary>
    public class ArrayQueue : IQueue
    {
		int[] queue;
		int size = 0;

		public ArrayQueue() 
		{
			queue = new int[0];
		}

        public int Peek()
        {
			return queue [0];
        }

        public int Pop()
        {
			int x = queue [0];
			int[] temp = new int[Size() - 1];
			for (int i = 0 ; i < Size() ; i++){
				temp [i] = queue [i + 1];
			}
			queue = temp;
			size--;
			return x;
        }

        public void Push(int value)
        {
			int[] temp = new int[Size()+1];
			for(int i = 0 ; i < Size() ; i++){
				temp[i] = queue[i];
			}
			temp [Size()] = value;
			queue = temp;
			size++;
        }

        public int Size()
        {
			return size;
        }
    }
}

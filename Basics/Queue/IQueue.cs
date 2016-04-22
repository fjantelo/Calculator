namespace Basics.Queue
{
    /// <summary>
    /// Queue is a data structure that contains elements and supports the below
    /// operations.
    /// </summary>
    public interface IQueue
    {
        /// <summary>
        /// Pop will remove the top element from the Queue and return it.
        /// </summary>
        /// <remarks>
        /// Note, this should throw an InvalidOperationException if 
        /// <paramref name="Pop"/> is called when the Queue is empty.
        /// </remarks>
        /// <returns>The top element in the Queue</returns>
        int Pop();

        /// <summary>
        /// Returns the top element in the Queue without removing it. Hence, 
        /// calling Peek() consecutively will return the same element.
        /// </summary>
        /// <remarks>
        /// Note, this should throw an InvalidOperationException if 
        /// <paramref name="Pop"/> is called when the Queue is empty.
        /// </remarks>
        /// <returns>The top element in the Queue</returns>
        int Peek();

        /// <summary>
        /// Inserts <paramref name="value"/> into the top of the Queue
        /// </summary>
        /// <param name="value"></param>
        void Push(int value);

        /// <summary>
        /// Returns the number of elements in Queue.
        /// </summary>
        /// <returns></returns>
        int Size();
    }
}

namespace Algorithims
{
    internal class StackWithQueue
    {
        Queue<int> queue;
        public StackWithQueue()
        {
            queue = new Queue<int>();
        }
        public void Push(int value) { 
            queue.Enqueue(value); // 1
        }
        public int Pop() { // O(n)
            for (int i = 0; i < queue.Count - 1; i++) { // n
                queue.Enqueue(queue.Dequeue()); // 2
            }
            return queue.Dequeue(); // 1
        }
        public bool IsEmpty()
        {
            return queue.Count == 0;
        }
    }
}

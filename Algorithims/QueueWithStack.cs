namespace Algorithims
{
    internal class QueueWithStack
    {
        Stack stack1;
        Stack stack2;
        public QueueWithStack()
        {
            stack1 = new Stack();
            stack2 = new Stack();
        }
        public bool IsEmpty()
        {
            return stack1.IsEmpty() && stack2.IsEmpty();
        }
        public void EnQueue(int value) // O(1)
        {
            stack1.Push(value); // 1
        }
        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException();
            }
            if (stack2.IsEmpty())
            {
                while (!stack1.IsEmpty())
                {
                    stack2.Push(stack1.Pop());
                }
            }
            return stack2.Pop();
        }
    }
}
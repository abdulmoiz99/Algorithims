namespace Algorithims
{
    internal class Stack
    {
        private int[] stack;
        private int rear = 0;
        private readonly int initialStackSize = 5;
        public Stack()
        {
            stack = new int[initialStackSize];
        }
        public void Push(int value)
        {
            if (rear >= stack.Length)
            {
                ResizeStack();
            }
            stack[rear++] = value;
        }
        public int Pop()
        {
            if (rear <= 0)
            {
                throw new Exception();
            }
            return stack[--rear];
        }
        public bool IsEmpty()
        {
            return rear == 0;
        }
        private void ResizeStack()
        {
            Array.Resize(ref stack, (int)(stack.Length * 1.5));
        }
    }
}

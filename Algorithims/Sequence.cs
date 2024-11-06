namespace Algorithims
{
    internal class Sequence
    {
        int[] array;
        int front, rear, arraySize;

        public Sequence()
        {
            arraySize = 10;
            array = new int[arraySize];
            front = 0;
            rear = 0;
        }
        public int Size() => (arraySize + rear - front) % arraySize;

        public bool IsEmpty() => front == rear;

        public int First()
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return array[front];
            }
        }

        public void InsertLast(int value)
        {
            if (Size() == arraySize - 1)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                array[rear] = value;
                rear = rear + 1 % arraySize;
            }
        }
        public int RemoveFirst()
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                int value = array[front];
                front = front + 1 % arraySize;
                return value;
            }
        }
    }
}

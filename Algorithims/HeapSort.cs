namespace Algorithims
{
    internal class HeapSort
    {
        int[] array;
        int pointer;
        public HeapSort()
        {
            array = new int[10];
            pointer = 1;
        }
        public void InsertItem(int value)
        {
            array[pointer] = value;
            UpHeap(pointer);
            pointer++;
        }
        public void UpHeap(int index)
        {
            if (index > 1)
            {
                int parent = index / 2;
                if (array[parent] > array[index])
                {
                    (array[parent], array[index]) = (array[index], array[parent]);
                }
                UpHeap(parent);
            }
        }
        public int Peek()
        {
            return array[1];
        }
        public void Print()
        {
            foreach (var item in array)
            {
                Console.Write(item + ", ");
            }
        }

    }
}

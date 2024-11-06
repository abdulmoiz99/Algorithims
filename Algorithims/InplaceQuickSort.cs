namespace Algorithims
{
    internal class InplaceQuickSort
    {
        public static void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        private static void Sort(int[] array, int low, int high)
        {
            if (low < high) 
            {
                int partitionIndex = Partition(array, low, high);
                Sort(array, partitionIndex + 1, high);  // Sort right side
                Sort(array, low, partitionIndex - 1);   // Sort left side
            }
        }

        private static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int j = low;

            for (int i = low; i < high; i++)
            {
                if (array[i] <= pivot)
                {
                    (array[j], array[i]) = (array[i], array[j]);
                    j++;
                }
            }

            (array[j], array[high]) = (array[high], array[j]);
            return j;
        }
    }
}

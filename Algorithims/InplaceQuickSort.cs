namespace Algorithims
{
    internal class InplaceQuickSort
    {
        public static void Sort(ref int[] array)
        {
            Sort(ref array, 0, array.Length - 1);
        }

        private static void Sort(ref int[] array, int low, int high)
        {
            if (low < high) // Correct base condition
            {
                int partitionIndex = Partition(array, low, high);
                Sort(ref array, partitionIndex + 1, high);  // Sort right side
                Sort(ref array, low, partitionIndex - 1);   // Sort left side
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

            // Place the pivot in its correct sorted position
            (array[j], array[high]) = (array[high], array[j]);
            return j;
        }
    }
}

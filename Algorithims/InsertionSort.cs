namespace Algorithims
{
    internal class InsertionSort
    {
        public static int[] Sort(int[] array)
        {
            int arraySize = array.Length;
            int[] result = new int[arraySize];
            result[0] = array[0];

            for (int i = 1; i < arraySize; i++)
            {
                int j = i;
                int elementToInsert = array[i];

                while (j > 0 && elementToInsert < result[j - 1])
                {
                    result[j] = result[j - 1];
                    j--;
                }
                result[j] = elementToInsert;
            }

            return result;
        }
    }
}

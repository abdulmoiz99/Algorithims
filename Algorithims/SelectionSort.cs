using System;
using System.Collections.Generic;
using System.Linq;
namespace Algorithims
{
    internal class SelectionSort
    {
        public static void Sort(ref int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                int indexToSwap = GetMinElementIndex(array, i);
                temp = array[i];
                array[i] = array[indexToSwap];
                array[indexToSwap] = temp;
            }
        }
        private static int GetMinElementIndex(int[] array, int startFrom)
        {
            int min = int.MaxValue;
            int index = -1;
            for (int i = startFrom; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }
            return index;
        }
    }
}

namespace Algorithims
{
    internal class Dictionary
    {
        int[] array;
        int arraySize = 13;
        public Dictionary()
        {
            array = new int[arraySize];
        }
        public void AddKey(int key)
        {
            int hashIndex = HashIndex(key);
            if (array[hashIndex] == 0 || array[hashIndex] == -1)
            {
                array[hashIndex] = key;
            }
            else 
            {
                int startIndex = hashIndex + 1;
                while (startIndex != hashIndex)
                {
                    if (array[startIndex] == 0 || array[startIndex] != -1)
                    {
                        array[startIndex] = key;
                        break;
                    }
                    else
                    {
                        startIndex++;
                        startIndex = HashIndex(startIndex);
                    }
                }
            }
        }
        public void GetAllKeys()
        {
            Console.WriteLine("KEY :: VALUE");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0 || array[i] != -1)
                {
                    Console.WriteLine(i + " :: " + array[i]);
                }
            }
        }
        private int HashIndex(int key) => key % arraySize;
    }
}

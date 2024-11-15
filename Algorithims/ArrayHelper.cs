namespace Algorithims
{
    internal class ArrayHelper
    {
        public static bool IsExlusiveOr(int[] A, int[] B, int[] C)
        {
            var dA = new Dictionary<int, byte>();
            var dB = new Dictionary<int, byte>();
            var dC = new Dictionary<int, byte>();

            LoadElementsIntoDictionary(A, dA, 0);
            LoadElementsIntoDictionary(B, dB, 0);
            LoadElementsIntoDictionary(C, dC, 0);

            RemoveDublicates(dA, dB);

            if (dA.Count == 0 || dB.Count == 0)
                return false;

            var dictionary = MergeDictionary(dA, dB);

            return Compare(dictionary, dC);

        }

        static void LoadElementsIntoDictionary(int[] array, Dictionary<int, byte> dictionary, int index)
        {
            if (index >= array.Length)
                return;

            if (!dictionary.ContainsKey(array[index]))
            {
                dictionary.Add(array[index], 0);
            }
            LoadElementsIntoDictionary(array, dictionary, index + 1);
        }

        static void RemoveDublicates(Dictionary<int, byte> dictionaryA, Dictionary<int, byte> dictionaryB)
        {
            foreach (var element in dictionaryA)
            {
                int key = element.Key;
                if (dictionaryA.ContainsKey(key) && dictionaryB.ContainsKey(key))
                {
                    dictionaryA.Remove(key);
                    dictionaryB.Remove(key);
                }
            }
        }
        static Dictionary<int, byte> MergeDictionary(Dictionary<int, byte> dictionaryA, Dictionary<int, byte> dictionaryB)
        {
            var dictionary = new Dictionary<int, byte>();
            dictionary = dictionaryA;
            foreach (var element in dictionaryB)
            {
                if (!dictionary.ContainsKey(element.Key))
                {
                    dictionary.Add(element.Key, 0);
                }
            }
            return dictionary;
        }

        static bool Compare(Dictionary<int, byte> dictionaryA, Dictionary<int, byte> dictionaryB)
        {
            if (dictionaryA.Count != dictionaryB.Count) return false;

            foreach (var element in dictionaryA)
            {
                if (!dictionaryA.ContainsKey(element.Key)) return false;
            }
            return true;
        }
    }
}

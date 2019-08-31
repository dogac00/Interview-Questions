using System.Collections.Generic;

namespace LargestFibonacciSubset
{
    class FirstSolution
    {
        static readonly Dictionary<int, bool> IsFibonacciDictionary = new Dictionary<int, bool>();

        public static List<int> GetLongestFibonacciSubset(int[] arr)
        {
            List<int> result = new List<int>();

            foreach (int num in arr)
            {
                if (IsFibonacci(num))
                    result.Add(num);
            }

            return result;
        }

        static bool IsFibonacci(int num)
        {
            bool result;

            if (IsFibonacciDictionary.TryGetValue(num, out result))
            {
                return result;
            }

            return IsFibonacciDictionary[num] = IsFibonacciInternal(num);
        }

        static bool IsFibonacciInternal(int num)
        {
            int result = 0;
            int f1 = 0, f2 = 1;

            while (result < num)
            {
                result = f1 + f2;
                f1 = f2;
                f2 = result;
            }

            return result == num;
        }
    }
}

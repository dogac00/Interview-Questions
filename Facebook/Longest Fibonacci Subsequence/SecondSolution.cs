using System.Collections.Generic;
using System.Linq;

namespace LargestFibonacciSubset
{
    class SecondSolution
    {
        public static List<int> GetLongestFibonacciSubset(int[] arr)
        {
            List<int> fibs = GenerateFibonacci(arr);
            List<int> results = new List<int>();

            foreach (int num in arr)
            {
                if (fibs.Contains(num))
                {
                    results.Add(num);
                }
            }

            return results;
        }

        static List<int> GenerateFibonacci(int[] arr)
        {
            int result = 0, first = 0, second = 1, max = arr.Max();
            List<int> results = new List<int>();

            while (result < max)
            {
                result = first + second;
                first = second;
                second = result;
                results.Add(result);
            }

            return results;
        }
    }
}

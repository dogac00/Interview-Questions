using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestFibonacciSubset
{
    class FindZeroSumTriplets
    {
        public static List<Tuple<int, int, int>> FindTriplets(int[] arr)
        {
            List<Tuple<int, int, int>> triplets = new List<Tuple<int, int, int>>();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == 0)
                            triplets.Add(Tuple.Create(arr[i], arr[j], arr[k]));
                    }
                }
            }

            return triplets;
        }
    }
}

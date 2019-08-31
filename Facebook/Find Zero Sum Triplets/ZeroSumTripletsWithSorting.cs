using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestFibonacciSubset
{
    class ZeroSumTripletsWithSorting
    {
        public static List<Tuple<int, int, int>> FindZeroSumTriplets(int[] arr)
        {
            List<Tuple<int, int, int>> triplets = new List<Tuple<int, int, int>>();

            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                int low = i + 1;
                int high = arr.Length - 1;

                while (low < high)
                {
                    if (arr[i] + arr[low] + arr[high] == 0)
                    {
                        triplets.Add(Tuple.Create(arr[i], arr[low], arr[high]));

                        high--;
                        low++;
                    }
                    else if (arr[i] + arr[low] + arr[high] < 0)
                    {
                        low++;
                    }
                    else
                    {
                        high--;
                    }
                }
            }

            return triplets;

            return triplets;
        }
    }
}

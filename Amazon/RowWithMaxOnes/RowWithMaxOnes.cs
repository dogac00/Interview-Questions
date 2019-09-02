using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestFibonacciSubset
{
    class RowWithMaxOnes
    {
        public static int GetRawWithMaxOnes(int[,] arr, int firstDim, int secondDim)
        {
            int max = 0;
            int maxIndex = 0;
            
            for (int i = 0; i < firstDim; i++)
            {
                int arrMax = 0;

                for (int j = 0; j < secondDim; j++)
                    arrMax += arr[i, j];

                if (arrMax > max)
                    maxIndex = i;
            }

            return maxIndex;
        }
    }
}

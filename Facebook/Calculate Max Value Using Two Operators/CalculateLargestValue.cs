using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestFibonacciSubset
{
    class CalculateLargestValue
    {
        public static int GetLargest(string str)
        {
            int result = str[0] - '0';

            for (int i = 0; i < str.Length - 1; i++)
            {
                result = GetMaxValue(result, str[i + 1]);
            }

            return result;
        }

        static int GetMaxValue(int result, int second)
        {
            int num2 = second - '0';

            if (result == 0 || num2 == 0)
                return result + num2;

            if (result == 1 || num2 == 1)
                return result + num2;

            return result * num2;
        }
    }
}

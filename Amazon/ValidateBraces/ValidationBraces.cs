using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class ValidationBraces
    {
        private static string _frontBraces = "[({";
        private static string _backBraces = "])}";

        public static string Validate(string braces)
        {
            int counter = 0;

            for (int i = 0; i < braces.Length; i++)
            {
                if (_frontBraces.Contains(braces[i])) counter++;

                else if (_backBraces.Contains(braces[i])) counter--;
            }

            return counter == 0 ? "Valid" : "Not Valid";
        }
    }
}

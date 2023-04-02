using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4B_assignment
{
    internal class ReverseInput
    {
        public static string Reverse(string input)
        {
            char[] charArray = input.ToCharArray();
            string reverseString = String.Empty;
            for(int i = charArray.Length-1;i> -1;i--)
            {
                reverseString += charArray[i];
            }
             return reverseString;
        }
    }
}

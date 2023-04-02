using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4B_assignment
{
    internal class DigitSum
    {
        public static void Sum()
        {
            Console.WriteLine("print the digoits is -: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int b;

            while (n != 0)
            {
                b = n % 10;
                sum = sum + b;
                n = n / 10;

            }
            Console.WriteLine("The sum of the digits is: " + sum);


        }
    }
}

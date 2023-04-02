using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4B_assignment
{
    internal class RightAngleTriange
    {
        public static void  RightAngle() {

            Console.WriteLine("No. of column  - :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n);

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }




        }
    }
}

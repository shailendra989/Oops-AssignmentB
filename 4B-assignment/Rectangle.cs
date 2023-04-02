using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4B_assignment
{
    internal class Rectangle
    {
        public static void RectanglePattern()
        {

            Console.WriteLine("No. of row  - :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n);

            Console.WriteLine("No. of column  - :");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(m);

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (i == 1 || i == n || j == 1 || j == m)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

            }
        }
    }
}

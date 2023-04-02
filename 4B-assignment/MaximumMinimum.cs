using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4B_assignment
{
    internal class MaximumMinimum
    {
        public static void  MaxMin() {

            Console.WriteLine("Size of array - :");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int count = 0;
            Console.WriteLine("Enter elements in the array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = arr[0];
            int min = arr[0];

            foreach(int num in arr) {

                if (num > max)
                {
                   max = num;
                }


                if(num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine("Maximum element is -  " + max);
            Console.WriteLine("minimum element is -  " + min);
        }
    }
}

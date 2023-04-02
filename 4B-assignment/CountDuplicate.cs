using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4B_assignment
{
    internal class CountDuplicate
    {
        public static void Count()
        {
            Console.WriteLine("Size of array - :");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int count =0;
            Console.WriteLine("Enter elements in the array: ");
            for ( int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("Total no. of duplicate elements "+count);


            

        }
    }
}

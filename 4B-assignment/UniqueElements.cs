using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4B_assignment
{
    internal class UniqueElements
    {
        public static void  Unique() {


            Console.WriteLine("Size of array - :");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int count = 0;
            Console.WriteLine("Enter elements in the array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            var  unique = arr.Distinct();
            Console.WriteLine("Unique elements in array -");
            foreach(var item in unique)
            {
                Console.WriteLine(item);
            }

        }
    }
}

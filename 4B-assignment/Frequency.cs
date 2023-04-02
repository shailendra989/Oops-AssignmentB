using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4B_assignment
{
     public  class Frequency
    {
        public static void FrequencyNum()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 1, 2, 3, 1 };
            int[] freq = new int[arr.Length];
            int visited = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        freq[j] = visited;
                    }
                }
                if (freq[i] != visited)
                {
                    freq[i] = count;
                }
            }

            Console.WriteLine("Element\tFrequency");
            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] != visited)
                {
                    Console.WriteLine(arr[i] + "\t" + freq[i]);
                }
            }
        }

    }
}

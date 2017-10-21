using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Since not using extra space and book keeping for number of elements it should be faster.
namespace HackerRank.Sorting
{
    class CountSortNotStableFaster
    {
        public static void Main(string[] args)
        {
            int[] arr = { 2, 5, 3, 0, 2, 3, 0, 3 };
            int k = 6;
            countSort(arr, k);

            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadKey();
        }

        static void countSort(int[] arr, int k)
        {
            int length = arr.Length;
            
            int[] numbers = new int[k + 1];

            for (int i = 0; i < length; i++)
            {
                numbers[arr[i]] += 1;

            }

            int index = 0;
            for (int i = 0; i <= k; i++)
            {
                for (int j = 0; j < numbers[i]; j++)
                {
                    arr[index++] = i;
                }
                
            }
            
        }
    }
}

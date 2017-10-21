using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Sorting
{
    public class CountSortingStable
    {

        //public static void Main(string[] args)
        //{
        //    int[] arr = { 2, 5, 3, 0, 2, 3, 0, 3 };
        //    int k = 6;
        //    int[] result = countSort(arr,k);

        //    int length = arr.Length;

        //    for (int i = 0; i < length; i++)
        //    {
        //        Console.Write(result[i]+" ");
        //    }

        //    Console.ReadKey();
        //}

        static int[] countSort(int[] arr, int k)
        {
            int length = arr.Length;
            int[] resultSorted = new int[length];
            int[] numbers = new int[k+1];

            for (int i = 0; i < length; i++)
            {
                numbers[arr[i]] += 1;

            }

            for (int i = 1; i <= k; i++)
            {
                numbers[i] = numbers[i] + numbers[i - 1];
            }

            for (int i = length-1; i >=0; i--)
            {
                resultSorted[numbers[arr[i]]-1] = arr[i];
                numbers[arr[i]]--;
            }

            return resultSorted;
        }
    }
}

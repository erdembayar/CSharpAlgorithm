using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Sorting
{
    public class InsertionSorting
    {
        public static void InsertionSort(int[] arr)
        {
            int len = arr.Length;
            if (len == 1)
                return;
            int temp = 0;
            int j = 0;

            for (int i = 1; i < len; i++)
            {
                temp = arr[i];
                j = i;
                while (j>0 && temp<arr[j-1])
                {
                    arr[j] = arr[j - 1];
                    j--;
                }

                arr[j] = temp;
            }
        }
    }
}

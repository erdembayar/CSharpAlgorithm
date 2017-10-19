using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.hackerrank.com/challenges/ctci-bubble-sort/problem

namespace HackerRank.Sorting
{
    public class BubbleSortImp
    {
        public static int BubbleSort(int[] a)
        {
            int count = 0;
            bool swapped = false;
            int len = a.Length;
            for (int i = 0; i < len; i++)
            {
                swapped = false;
                for (int j = 0; j < len - 1 - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        swap(a, j, j + 1);
                        count++;
                        swapped = true;
                    }
                }


                if (!swapped)
                {
                    break;
                }
            }

            return count;
        }

        protected static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }
}

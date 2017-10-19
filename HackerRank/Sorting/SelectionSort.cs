using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Sorting
{
    public class SelectionSorting
    {
        public static void SelectionSort(int[] a)
        {
            int length = a.Length;
            int minIndex = 0;
            for (int i = 0; i < length; i++)
            {
                minIndex = nextMin(a, i, length - 1);
                swap(a, i, minIndex);
            }
        }

        public static int nextMin(int[] arr, int start, int end)
        {
            int index = start;
            int min = arr[start];
            for (int i = start; i <= end; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    index = i;
                }
            }

            return index;
        }

        public static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Good for numbers have not much variation in lengths and with limited range for(Max,Min).
//Sorting 1 million 64 bit numbers.(Actually limit <=9999)
// Treat as four digit radix 2^16 numbers.
// Can sort in just 4 passes (because we have 4 digits only) with radix sort.

namespace HackerRank.Sorting
{
    class RadixSorting
    {

        public static void Main(string[] args)
        {
            int[] arr = { 170, 45, 75, 90, 1802, 24, 2, 66,2 };

            radixSort(arr);

            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadKey();
        }

        static void radixSort(int[] arr)
        {
            int length = arr.Length;
            if (length <= 1)
                return;

            int max = findMax(arr);

            int digits = max.ToString().Length;

            for (int d = 1; d <= digits; d++)
            {
                countSortStable(arr, d);
            }
        }

        static int getDigitAt(int a, int d) {
            return a % (int)Math.Pow(10, d) / (int)(Math.Pow(10, d - 1));
        }

        static void countSortStable(int[] arr, int d)
        {
           
            int length = arr.Length;
            int[] result = new int[length];

            int[] C = new int[10]; //Because we only keep digits

            for (int i = 0; i < length; i++)
            {
                int digit = (getDigitAt(arr[i],d));
                C[digit] += 1;
            }

            for (int i = 1; i < 10; i++)
            {
                C[i] = C[i] + C[i - 1];
            }

            for (int i = length-1; i>=0; i--)
            {
                result[C[getDigitAt(arr[i], d)]-1] = arr[i];
                C[getDigitAt(arr[i], d)]--;
            }

            for (int i = 0; i < length; i++)
            {
                arr[i] = result[i];
            }
        }

        static int findMax(int[] arr)
        {
            int length = arr.Length;

            int max = arr[0];
            for (int i = 1; i < length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }

            return max;

        }
    }
}

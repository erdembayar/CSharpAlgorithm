using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.hackerrank.com/challenges/ctci-recursive-staircase
//https://www.youtube.com/watch?v=eREiwuvzaUM

namespace HackerRank.Algorithm
{
    class RecursiveStaircase
    {
        //static void Main(string[] args)
        //{
        //    int steps = 32;
            

        //    var sw = Stopwatch.StartNew();
        //    int result = countPathsRecursive(steps);
        //    sw.Stop();

        //    Console.WriteLine("Brute force recursive:" + result);
        //    Console.WriteLine("Time elapse:"+sw.Elapsed);

        //    sw.Reset();
        //    sw.Start();
        //    int[] memo = new int[steps + 1];

        //    result = countPathsMemozation(memo, steps);
        //    sw.Stop();

        //    Console.WriteLine("Memoziation recursive:" + result);
        //    Console.WriteLine("Time elapse:" + sw.Elapsed);

        //    sw.Reset();
        //    sw.Start();

        //    result = countPathDynamicProgramming(steps);
        //    sw.Stop();

        //    Console.WriteLine("Dynamic programming:" + result);
        //    Console.WriteLine("Time elapse:" + sw.Elapsed);

        //    Console.ReadKey();

            
        //}

        static int countPathsRecursive(int steps)
        {
            if (steps < 0)
                return 0;
            if (steps == 0 || steps == 1)
                return 1;

            return countPathsRecursive(steps - 1) + countPathsRecursive(steps - 2) + countPathsRecursive(steps-3);
        }

        static int countPathsMemozation(int[] memo, int steps)
        {
            if (steps < 0)
                return 0;
            if (steps == 0 || steps == 1)
                return 1;

            if (steps == 2)
                return 2;

            if (memo[steps]==0)
                return countPathsMemozation(memo, steps - 1) + countPathsMemozation(memo, steps - 2) + countPathsMemozation(memo, steps - 3);

            return memo[steps];
        }

        static int countPathDynamicProgramming(int steps)
        {
            if (steps < 0)
                return 0;
            if (steps == 0 || steps == 1)
                return 1;

            int[] paths = new int[steps + 1];
            paths[0] = 1;
            paths[1] = 1;
            paths[2] = 2;

            for (int i = 3; i <= steps; i++)
            {
                paths[steps] = paths[steps - 1] + paths[steps - 2] + paths[steps - 3];
            }

            return paths[steps];
        }

    }


}

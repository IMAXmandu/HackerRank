using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

        long min = long.MaxValue;
        long max = long.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            long sum = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (i != j) sum += arr[j];
            }
            if (min > sum) min = sum;
            if (max < sum) max = sum;
        }

        Console.WriteLine(min + " " + max);
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

        float positive = 0;
        float negative = 0;
        float zero = 0;
        foreach (int item in arr)
        {
            if (item > 0) positive++;
            else if (item < 0) negative++;
            else zero++;
        }
        Console.WriteLine((float)(positive / n));
        Console.WriteLine((float)(negative / n));
        Console.WriteLine((float)(zero / n));
    }
}
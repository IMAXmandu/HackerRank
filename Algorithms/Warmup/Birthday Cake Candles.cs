using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int birthdayCakeCandles(int n, int[] ar)
    {
        int max = 0;
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            if(max < ar[i])
            {
                max = ar[i];
                count = 1;
            }
            else if (max == ar[i])
            {
                count++;
            }
        }

        return count;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
        int result = birthdayCakeCandles(n, ar);
        Console.WriteLine(result);
    }
}
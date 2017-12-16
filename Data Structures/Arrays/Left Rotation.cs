using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static int[] leftRotation(int[] a, int d)
    {
        int[] b = new int[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            // Move Right
            b[(i + (a.Length - d)) % a.Length] = a[i];
        }
        return b;
    }

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int d = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        int[] result = leftRotation(a, d);
        Console.WriteLine(String.Join(" ", result));
    }
}

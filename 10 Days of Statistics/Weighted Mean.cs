using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
        int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

        double weightedSum = 0;
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += arr2[i];
            weightedSum += arr1[i] * arr2[i];
        }
        Console.WriteLine(string.Format("{0:F1}", weightedSum / sum));
    }
}
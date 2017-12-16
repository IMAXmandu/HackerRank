using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string strAr = Console.ReadLine();
        int[] ar = Array.ConvertAll(strAr.Split(' '), Int32.Parse);

        double sum = 0;
        foreach (var item in ar)
        {
            sum += item;
        }
        Console.WriteLine(String.Format("{0:F1}", sum / n));

        Array.Sort(ar);
        if(n % 2 == 0)  Console.WriteLine(String.Format("{0:F1}", (ar[n/2 - 1] + ar[n/2]) / 2.0));
        else Console.WriteLine(ar[n / 2]);

        int count = 1;
        int result = ar[0];

        int compare = ar[0];
        int compareCount = 1;
        for (int i = 1; i < n; i++)
        {
            if (compare == ar[i]) compareCount++;
            else
            {
                if(compare == result)
                {
                    count = compareCount;
                }
                else if(count < compareCount)
                {
                    count = compareCount;
                    result = compare;
                }

                compare = ar[i];
                compareCount = 1;
            }
        }
        Console.WriteLine(result);
    }
}
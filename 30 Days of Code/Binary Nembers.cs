using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string s = Convert.ToString(n, 2);

        int max = 0;
        int current = 0;
        foreach (var item in s)
        {
            if (item.ToString() == "1") current++;
            else if (item.ToString() == "0" && current > max)
            {
                max = current;
                current = 0;
            }
            else
            {
                current = 0;
            }
        }

        if (current > max) max = current;
        Console.WriteLine(max);
    }
}

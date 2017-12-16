using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            long p = long.Parse(Console.ReadLine());
            if (p == 1)
            {
                Console.WriteLine("Not prime");
                continue;
            }

            bool isPrime = true;

            long m = (long)Math.Sqrt(p);
            for (long j = 2; j <= m; j++)
            {
                if (p % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime == false) Console.WriteLine("Not prime");
            else Console.WriteLine("Prime");
        }
    }
}
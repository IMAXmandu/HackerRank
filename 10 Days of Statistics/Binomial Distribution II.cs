using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        double p = 0.12;
        int    n = 10;
        
        /* "No more than 2 rejects" */
        double result = 0;
        for (int x = 0; x <= 2; x++) {
            result += binomial(n, x, p);
        }
        Console.WriteLine(string.Format("{0:f3}",result));

        /* "at least 2 rejects" */
        result = 1 - (binomial(n, 0, p) + binomial(n, 1, p));
        Console.WriteLine(string.Format("{0:f3}", result));
    }

    private static Double binomial(int n, int x, double p)
    {
        return combinations(n, x) * Math.Pow(p, x) * Math.Pow(1 - p, n - x);
    }

    private static long combinations(int n, int x)
    {
        return factorial(n) / (factorial(x) * factorial(n - x));
    }

    private static long factorial(int n)
    {
        long result = 1;
        while (n > 0)
        {
            result *= n--;
        }
        return result;
    }
}
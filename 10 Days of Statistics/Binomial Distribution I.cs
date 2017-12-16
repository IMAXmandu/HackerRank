using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        double BOYratio = 1.09;
        double GIRLratio = 1;
        double p = BOYratio / (GIRLratio + BOYratio);
        int    n = 6;
        
        /* Calculate result */
        double result = 0;
        for (int x = 3; x <= n; x++) {
            result += binomial(n, x, p);
        }
        Console.WriteLine(string.Format("{0:f3}",result));
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
using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        /* Provided variables */
        double mean   = 500;
        double std    = 80;
        int    n      = 100;
        double zScore = 1.96; // equivalent to 95% confidence interval
        
        /* Formula (found online) for confidence interval +/- */
        double marginOfError = zScore * std / Math.Sqrt(n);

        /* Print output */
        Console.WriteLine(string.Format("{0:F2}", mean - marginOfError));
        Console.WriteLine(string.Format("{0:F2}", mean + marginOfError));
    }
}
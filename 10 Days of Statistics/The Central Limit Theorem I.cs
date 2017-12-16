using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        Console.WriteLine(Math.Round(0.5 * (1 + erf((9800 - 49 * 205) / ((Math.Sqrt(49) * 15) * Math.Sqrt(2)))), 4));
    }

    public static double erf(double z)
    {
        double t = 1.0 / (1.0 + 0.5 * Math.Abs(z));

        // use Horner's method
        double ans = 1 - t * Math.Exp(-z * z - 1.26551223 +
                                            t * (1.00002368 +
                                            t * (0.37409196 +
                                            t * (0.09678418 +
                                            t * (-0.18628806 +
                                            t * (0.27886807 +
                                            t * (-1.13520398 +
                                            t * (1.48851587 +
                                            t * (-0.82215223 +
                                            t * (0.17087277))))))))));
        if (z >= 0) return ans;
        else return -ans;
    }
}
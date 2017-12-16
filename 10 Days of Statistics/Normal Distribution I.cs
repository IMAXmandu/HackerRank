using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        Console.WriteLine(n_std_dev(20, 2, 19.5));
        Console.WriteLine(n_std_dev(20, 2, 22) - n_std_dev(20, 2, 20));
    }

    static double n_std_dev(int m, int sd, double a)
    {
        double b = erf((a - m) / (sd * Math.Pow(2.0, 0.5)));
        return 0.5 * (1 + b);
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
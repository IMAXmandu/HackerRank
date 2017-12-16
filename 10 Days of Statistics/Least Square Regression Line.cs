using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Solution
{
    static void Main(String[] args)
    {
         /* Hardcoded data */
        int [] x = {95, 85, 80, 70, 60};
        int [] y = {85, 95, 70, 65, 70};
        double studentScore = 80;
        
        /* Get coefficients for Least Square Regression Line */
        double b = pearson(x, y) * (standardDeviation(y) / standardDeviation(x));
        double a = getMean(y) - b * getMean(x);
        
        /* Calculate and print predicted score */
        double result = a + b * studentScore;
        Console.WriteLine(string.Format("{0:F3}", result));
    }

    /* Calculates Pearson coefficient */
    private static Double pearson(int[] xs, int[] ys)
    {
        double xMean = getMean(xs);
        double yMean = getMean(xs);
        int n = xs.Length;

        double numerator = 0;
        for (int i = 0; i < n; i++)
        {
            numerator += (xs[i] - xMean) * (ys[i] - yMean);
        }
        return numerator / (n * standardDeviation(xs) * standardDeviation(ys));
    }

    private static Double getMean(int[] array) {
        int total = 0;
        foreach (var num in array)
	    {
		    total += num;
	    }
        return (double) total / array.Length;
    }

    private static Double standardDeviation(int[] array) {
        double mean = getMean(array);
        int sum = 0;
        foreach (double x in array)
        {
            sum += (int)Math.Pow(x - mean, 2);
        }
        double variance = sum / array.Length;
        return Math.Sqrt(variance);
    }
}
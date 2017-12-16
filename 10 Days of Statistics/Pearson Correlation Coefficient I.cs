using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
public class Solution
{
    static void Main(String[] args) {
        /* Read and save input */
        Console.ReadLine();
        double [] xs = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), double.Parse);
        double[] ys = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), double.Parse);
        
       Console.WriteLine(pearson(xs, ys));
    }

    /* Calculates Pearson coefficient */
    static Double pearson(double[] xs, double[] ys)
    {
        double xMean = getMean(xs);
        double yMean = getMean(xs);
        int n = xs.Length;

        double numerator = 0;
        for (int i = 0; i < xs.Length; i++)
        {
            numerator += (xs[i] - xMean) * (ys[i] - yMean);
        }
        return numerator / (n * standardDeviation(xs) * standardDeviation(ys));
    }

    static Double getMean(double[] array) {
        double total = 0;
        foreach (var item in array)
	    {
		    total += item;
	    }
        return total / array.Length;
    }

    static Double standardDeviation(double[] array) {
        double mean = getMean(array);
        double sum = 0;
        foreach (var item in array)
        {
            sum += Math.Pow(item - mean, 2);
        }
        double variance = sum / array.Length;
        return Math.Sqrt(variance);
    }
}
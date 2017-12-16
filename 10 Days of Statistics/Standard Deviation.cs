using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        Console.ReadLine();
        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        
        double sum = 0;
        foreach(int item in ar) sum += item;
        double mean = sum / ar.Length;
        
        double variances = 0;
        foreach(int item in ar)
        {
            variances += (item - mean) * (item - mean);
        }
        Console.WriteLine(String.Format("{0:F1}",Math.Sqrt(variances / ar.Length)));
    }
}
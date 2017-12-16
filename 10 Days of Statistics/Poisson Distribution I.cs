using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args)
    {
        double result = Math.Pow(2.71828, -2.5) * Math.Pow(2.5, 5) / factorial(5);
        Console.WriteLine(string.Format("{0:f3}", result));
    }

    static int factorial(int n)
    {
        if (n > 1)  return n * factorial(n - 1);
        else return 1;
    }
}
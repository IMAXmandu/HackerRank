using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        double p = 0.3333;
        int    n = 5;
        
        double result = p * Math.Pow((1 - p), n - 1);
        Console.WriteLine(string.Format("{0:f3}", result));
    }
}
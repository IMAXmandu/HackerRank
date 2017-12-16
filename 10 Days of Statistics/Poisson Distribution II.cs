using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args)
    {
        Console.WriteLine(string.Format("{0:f3}", (160 + 40 * (0.88 + Math.Pow(0.88, 2)))));
        Console.WriteLine(string.Format("{0:f3}", (128 + 40 * (1.55 + Math.Pow(1.55, 2)))));
    }
}
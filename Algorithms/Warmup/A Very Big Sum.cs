using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static long aVeryBigSum(int n, long[] ar) {
        long result = 0;
        for(int i = 0; i < n; i++)
        {
            result += ar[i];         
        }
        return result;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        long[] ar = Array.ConvertAll(ar_temp,Int64.Parse);
        long result = aVeryBigSum(n, ar);
        Console.WriteLine(result);
    }
}

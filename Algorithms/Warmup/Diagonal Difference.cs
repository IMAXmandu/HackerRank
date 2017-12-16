using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];

        int x = 0;
        int y = 0;
        for (int a_i = 0; a_i < n; a_i++)
        {
            string[] a_temp = Console.ReadLine().Split(' ');
            a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);

            x += a[a_i][a_i];
            y += a[a_i][n - 1 - a_i];
        }
        Console.Write(Math.Abs(x-y));
    }
}

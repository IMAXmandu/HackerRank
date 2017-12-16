using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int[] actual = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int[] expect = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        if (actual[2] > expect[2]) Console.WriteLine("10000");
        else if ((actual[2] == expect[2]) && (actual[1] > expect[1])) Console.WriteLine(500 * (actual[1] - expect[1]));
        else if ((actual[2] == expect[2]) && (actual[1] == expect[1]) && (actual[0] > expect[0])) Console.WriteLine(15 * (actual[0] - expect[0]));
        else Console.WriteLine("0");
    }
}
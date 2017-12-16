using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        long[] input = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
        long[] array = new long[input[0] + 1];
        for (int i = 0; i < input[1]; i++)
        {
            long[] op = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            array[op[0]] += op[2];
            if (op[1] + 1 <= input[0]) array[op[1] + 1] -= op[2];
        }

        long max = 0;
        long sum = 0;
        for (int i = 1; i <= input[0]; i++)
        {
            sum += array[i];
            if (sum > max) max = sum;
        }

        Console.WriteLine(max);
    }
}

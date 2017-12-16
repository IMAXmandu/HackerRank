using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        Console.ReadLine();
        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        Array.Sort(ar);

        int Q1 = 0;
        int Q2 = 0;
        int Q3 = 0;

        if (ar.Length % 2 == 0) Q2 = (ar[ar.Length / 2] + ar[ar.Length / 2 - 1]) / 2;
        else Q2 = ar[ar.Length / 2];

        List<int> lowHalf = new List<int>();
        List<int> upperHalf = new List<int>();
        foreach (var item in ar)
        {
            if (item < Q2) lowHalf.Add(item);
            else if (item > Q2) upperHalf.Add(item);
        }

        if (lowHalf.Count % 2 == 0) Q1 = (lowHalf[lowHalf.Count / 2] + lowHalf[lowHalf.Count / 2 - 1]) / 2;
        else Q1 = lowHalf[lowHalf.Count / 2];
        if(upperHalf.Count % 2 == 0) Q3 = (upperHalf[upperHalf.Count / 2] + upperHalf[upperHalf.Count / 2 - 1]) / 2;
        else Q3 = upperHalf[upperHalf.Count / 2];

        Console.WriteLine(Q1);
        Console.WriteLine(Q2);
        Console.WriteLine(Q3);
    }
}
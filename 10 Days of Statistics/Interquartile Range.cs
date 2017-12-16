using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        Console.ReadLine();
        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int[] frequency = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        List<int> list = new List<int>();
        for (int i = 0; i < ar.Length; i++)
        {
            for (int j = 0; j < frequency[i]; j++)
            {
                list.Add(ar[i]);
            }
        }
        list.Sort();
        
        List<int> lowHalf = new List<int>();
        List<int> upperHalf = new List<int>();
        for (int i = 0; i < list.Count; i++)
        {
            if (list.Count % 2 == 0)
            {
                if (i < list.Count / 2) lowHalf.Add(list[i]);
                else upperHalf.Add(list[i]);
            }
            else
            {
                if (i < list.Count / 2) lowHalf.Add(list[i]);
                else if (i > list.Count / 2) upperHalf.Add(list[i]);
            }
        }

        double Q1 = 0;
        double Q3 = 0;
        if (lowHalf.Count < 2) Q1 = 0;
        else if (lowHalf.Count % 2 == 0) Q1 = (lowHalf[lowHalf.Count / 2] + lowHalf[lowHalf.Count / 2 - 1]) / 2.0;
        else Q1 = lowHalf[lowHalf.Count / 2];

        if (upperHalf.Count < 2) Q3 = 0;
        else if (upperHalf.Count % 2 == 0) Q3 = (upperHalf[upperHalf.Count / 2] + upperHalf[upperHalf.Count / 2 - 1]) / 2.0;
        else Q3 = upperHalf[upperHalf.Count / 2];
        Console.Write(string.Format("{0:F1}", Q3 - Q1));
    }
}
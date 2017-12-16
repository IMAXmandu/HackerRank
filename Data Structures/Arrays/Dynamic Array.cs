using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        List<List<int>> seq = new List<List<int>>();
        int lastAnswer = 0;

        for (int i = 0; i < arr[0]; i++)
        {
            seq.Add(new List<int>());
        }

        for (int i = 0; i < arr[1]; i++)
        {
            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int index = (q[1] ^ lastAnswer) % arr[0];

            if(q[0] == 1)
            {
                seq[index].Add(q[2]);
            }
            else if (q[0] == 2)
            {
                int value = q[2] % seq[index].Count;
                lastAnswer = seq[index][value];
                Console.WriteLine(lastAnswer);
            }
        }
    }
}
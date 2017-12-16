using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static int[] unionTree;
    static int[] size;

    static void Main(String[] args)
    {
        int q = int.Parse(Console.ReadLine());
        
        unionTree = new int[30001];
        size = new int[30001];
        
        for (int i = 0; i <= 30000; i++)
        {
            unionTree[i] = i;
            size[i] = 1;
        }

        int maxIndex = 0;
        for (int i = 0; i < q; i++)
        {
            string input = Console.ReadLine();
            int a = int.Parse(input.Split(' ')[0]);
            int b = int.Parse(input.Split(' ')[1]);
            if (b > maxIndex) maxIndex = b;
            Union(a, b);
        }

        int min = int.MaxValue;
        int max = int.MinValue;
        for (int i = 1; i <= maxIndex; i++)
        {
            int s = size[find(i)];
            if (s != 1)
            {
                if (s < min) min = s;
                else if (s > max) max = s;
            }
        }
        Console.Write(min + " " + max);
    }

    static int find(int root)
    {
        if (root == unionTree[root]) return root;
        return unionTree[root] = find(unionTree[root]);
    }

    static void Union(int com1, int com2)
    {
        com1 = find(com1);
        com2 = find(com2);
        if (com1 == com2) return;
        
        unionTree[com2] = com1;
        size[com1] += size[com2];
        size[com2] = size[com1];
    }
}
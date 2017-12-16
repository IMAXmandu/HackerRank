using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static int[] unionTree;
    static int[] size;

    static void Main(String[] args)
    {
        string input = Console.ReadLine();
        int n = int.Parse(input.Split(' ')[0]);
        int q = int.Parse(input.Split(' ')[1]);
        unionTree = new int[n + 1];
        size = new int[n + 1];
        
        for (int i = 0; i <= n; i++)
        {
            unionTree[i] = i;
            size[i] = 1;
        }

        for (int i = 0; i < q; i++)
        {
            input = Console.ReadLine();
            if (input.Split(' ')[0] == "Q") Query(int.Parse(input.Split(' ')[1]));
            else if (input.Split(' ')[0] == "M") Union(int.Parse(input.Split(' ')[1]), int.Parse(input.Split(' ')[2]));
        }
    }

    static void Query(int com)
    {
        Console.WriteLine(size[find(com)]);
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
        if (size[com1] > size[com2])
        {
            unionTree[com2] = com1;
            size[com1] += size[com2];
        }
        else
        {
            unionTree[com1] = com2;
            size[com2] += size[com1];
        }
    }
}
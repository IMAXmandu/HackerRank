using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<string> list = new List<string>();
        for (int i = 0; i < n; i++)
        {
            list.Add(Console.ReadLine());
        }

        int q = int.Parse(Console.ReadLine());
        for (int i = 0; i < q; i++)
        {
            string s = Console.ReadLine();
            Console.WriteLine(list.FindAll(x => x == s).Count);
        }
    }
}
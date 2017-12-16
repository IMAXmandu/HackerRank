using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, string> dic = new Dictionary<string, string>();
        for (int i = 0; i < n; i++ )
        {
            string input = Console.ReadLine();
            dic.Add(input.Split(' ')[0], input.Split(' ')[1]);
        }

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string value = string.Empty;
            dic.TryGetValue(input, out value);
            if (value == null) Console.WriteLine("Not found");
            else Console.WriteLine(input + "=" + value);
        }
    }
}
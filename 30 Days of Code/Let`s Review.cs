using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string str = Console.ReadLine();
            string even = "";
            string odd = "";
            for (int j = 0; j < str.Length; j++)
            {
                if (j % 2 == 0) even += str[j];
                else odd += str[j];
            }

            Console.WriteLine(even + " " + odd);
        }
    }
}
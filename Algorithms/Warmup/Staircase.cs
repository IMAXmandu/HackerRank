using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        for (int a = 1; a <= n; a++)
        {
            for (int i = n - a; i > 0; i--)
            {
                Console.Write(' ');
            }
            for (int i = 0; i < a; i++)
            {
                Console.Write('#');
            }
            Console.WriteLine();
        }
    }
}

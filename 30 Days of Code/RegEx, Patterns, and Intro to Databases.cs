using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        List<string> name = new List<string>();
        for (int a0 = 0; a0 < N; a0++)
        {
            string[] tokens_firstName = Console.ReadLine().Split(' ');
            string firstName = tokens_firstName[0];
            string emailID = tokens_firstName[1];
            if("gmail.com" == emailID.Split('@')[1]) name.Add(firstName);
        }

        name.Sort();

        foreach (var item in name)
        {
            Console.WriteLine(item);
        }
    }
}

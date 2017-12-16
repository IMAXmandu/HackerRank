using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static string timeConversion(string s)
    {
        if(s.Contains("AM") == true)
        {
            if (s.Split(':')[0] == "12")
            {
                return ("00:" + s.Split(':')[1] + ":" + s.Split(':')[2]).Replace("AM", "");
            }
            else
            {
                return s.Replace("AM", "");
            }
        }
        else
        {
            if (s.Split(':')[0] == "12")
            {
                return ("12:" + s.Split(':')[1] + ":" + s.Split(':')[2]).Replace("PM", "");
            }
            else
            {
                return ((int.Parse(s.Split(':')[0]) + 12).ToString() + ":" + s.Split(':')[1] + ":" + s.Split(':')[2]).Replace("PM", "");
            }
        }
    }

    static void Main(String[] args)
    {
        string s = Console.ReadLine();
        string result = timeConversion(s);
        Console.WriteLine(result);
    }
}

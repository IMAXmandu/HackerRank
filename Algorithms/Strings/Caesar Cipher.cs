using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string s = Console.ReadLine();
        int k = Convert.ToInt32(Console.ReadLine());

        if ((n < 1 && n > 100) ||
            (k < 0 && k > 100) ||
            (s.Length != n)) return;

        if (k > 26) k %= 26;
        
        string answer = string.Empty;
        foreach(char c in s.ToCharArray())
        {
            if (char.IsLetter(c) == true)
            {
                char newchar = (char)(c + k);
                if ( char.IsLower(c) && newchar > 'z') newchar = (char)('a' + (newchar - 'z') - 1);
                else if (char.IsUpper(c) && newchar > 'Z') newchar = (char)('A' + (newchar - 'Z') - 1);
                answer += newchar;
            }
            else
            {
                answer += c;
            }
        }
        Console.Write(answer);
    }
}

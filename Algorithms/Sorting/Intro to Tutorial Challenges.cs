using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int value = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
        for(int i=0; i<n; i++)
        {
            if(ar[i] == value)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
        if(N % 2 != 0) Console.WriteLine("Weird");
        else
        {
            if(2 <= N && N <= 5) Console.WriteLine("Not Weird");
            else if(6 <= N && N <= 20) Console.WriteLine("Weird");
            else if(20 < N) Console.WriteLine("Not Weird");
        }
    }
}

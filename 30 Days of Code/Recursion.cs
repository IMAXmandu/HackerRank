using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int factorial(int n) {
        if(n == 1 ) return 1;
        else return  n * factorial(n - 1);
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int result = factorial(n);
        Console.WriteLine(result);
    }
}

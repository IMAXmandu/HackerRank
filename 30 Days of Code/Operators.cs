using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        double mealCost = double.Parse(Console.ReadLine());
        int tip = int.Parse(Console.ReadLine());
        int tax = int.Parse(Console.ReadLine());
        
        double totalCost = mealCost + (mealCost*tip/100) + (mealCost*tax/100);
        Console.WriteLine("The total meal cost is " + Math.Round(totalCost) + " dollars.");
    }
}
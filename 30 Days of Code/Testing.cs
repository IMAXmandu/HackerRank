using System;
class Solution
{
    static void Main(String[] args)
    {
        Console.WriteLine("5");

        // Yes
        Console.WriteLine("4 3");
        Console.WriteLine("-1 -3 4 2");

        // No
        Console.WriteLine("5 2");
        Console.WriteLine("0 -1 2 1 4");

        // Yes
        Console.WriteLine("6 3");
        Console.WriteLine("0 -1 2 1 4 5");

        // No
        Console.WriteLine("7 3");
        Console.WriteLine("-1 -3 0 2 4 3 5");

        // Yes
        Console.WriteLine("8 4");
        Console.WriteLine("0 -1 2 1 4 6 7 9");
    }
}
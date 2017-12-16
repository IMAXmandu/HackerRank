        
        // Declare second integer, double, and String variables.
        int first = 0;
        double second = 0.0;
        string third = string.Empty;

        // Read and save an integer, double, and String to your variables.
        first = int.Parse(Console.ReadLine());
        second = double.Parse(Console.ReadLine());
        third = Console.ReadLine();

        // Print the sum of both integer variables on a new line.
        Console.WriteLine(first + i);
        
        // Print the sum of the double variables on a new line.
        Console.WriteLine(String.Format("{0:F1}",d + second));

        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(s + third);

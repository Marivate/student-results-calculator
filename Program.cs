using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Student Result System ===");

        // Student name
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        // Marks
        double mark1 = GetValidMark("Enter mark for Subject 1: ");
        double mark2 = GetValidMark("Enter mark for Subject 2: ");
        double mark3 = GetValidMark("Enter mark for Subject 3: ");

        // Calculations
        double total = mark1 + mark2 + mark3;
        double average = total / 3;

        string result = (average >= 50) ? "PASS" : "FAIL";

        // Output
        Console.WriteLine("\n=== Results ===");
        Console.WriteLine($"Student Name: {name}");
        Console.WriteLine($"Total Marks: {total}");
        Console.WriteLine($"Average: {average:F2}");
        Console.WriteLine($"Result: {result}");

        Console.ReadLine();
    }

    static double GetValidMark(string message)
    {
        double mark;
        while (true)
        {
            Console.Write(message);
            if (double.TryParse(Console.ReadLine(), out mark))
            {
                return mark;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }
    }
}
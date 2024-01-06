using System;

class Program2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int num1 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = Convert.ToInt16(Console.ReadLine());

        int addition = num1 + num2;
        int subtraction = num1 - num2;
        int multiplication = num1 * num2;

        if (num2 != 0)
        {
            int division = num1 / num2;
            Console.WriteLine($"Addition: {addition}");
            Console.WriteLine($"Subtraction: {subtraction}");
            Console.WriteLine($"Multiplication: {multiplication}");
            Console.WriteLine($"Division: {division}");
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }
}

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result;

        switch (op)
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine("Result: " + result);
                break;

            case "-":
                result = num1 - num2;
                Console.WriteLine("Result: " + result);
                break;

            case "*":
                result = num1 * num2;
                Console.WriteLine("Result: " + result);
                break;

            case "/":
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine("Result: " + result);
                }
                else
                {
                    Console.WriteLine("Error: Division by zero!");
                }
                break;

            default:
                Console.WriteLine("Invalid operator.");
                break;
        }
    }
}

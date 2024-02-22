sing System;

class SimpleCalculator
{
    static void Main()
    {
        bool continueCalculations = true;

        while (continueCalculations)
        {
            Console.WriteLine("Simple Calculator");

            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Select operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            Console.Write("Enter your choice (1/2/3/4): ");
            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Move to the next line after input

            double result = 0;

            switch (choice)
            {
                case '1':
                    result = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {result}");
                    break;
                case '2':
                    result = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = {result}");
                    break;
                case '3':
                    result = num1 * num2;
                    Console.WriteLine($"{num1} * {num2} = {result}");
                    break;
                case '4':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            Console.Write("Do you want to perform another calculation? (y/n): ");
            char continueChoice = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Move to the next line after input

            continueCalculations = (continueChoice == 'y' || continueChoice == 'Y');
        }
    }
}
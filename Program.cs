using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersOfCupsOfCoffee = 1;

            var name = "Corey Hall";

            var today = "01//05/20";

            Console.WriteLine(numbersOfCupsOfCoffee);

            Console.WriteLine(name);

            Console.WriteLine(today);

            Console.WriteLine($"I {name}, on this date {today}, had {numbersOfCupsOfCoffee} cup of coffee.");

            Console.WriteLine();

            Console.WriteLine("Hello, what is your name?");

            var userName = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine($"It is a pleasure to meet you, {userName}!");

            Console.WriteLine();

            Console.WriteLine($"{userName}, may I have two numbers?");

            var firstNumberAsString = Console.ReadLine();
            var secondNumberAsString = Console.ReadLine();

            Console.WriteLine();

            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);

            var sum = firstOperand + secondOperand;

            Console.WriteLine($"If you add {firstNumberAsString} to {secondNumberAsString}, that will equal {sum}");

            Console.WriteLine();

            var difference = secondOperand - firstOperand;

            Console.WriteLine($" If you subtract {secondOperand} from {firstOperand}, that equals {difference}");

            Console.WriteLine();

            var product = firstOperand * secondOperand;

            Console.WriteLine($" If multiply {firstOperand} by {secondOperand}, that will equal {product}");

            Console.WriteLine();

            var quotient = firstOperand / secondOperand;

            Console.WriteLine($"If you divide {firstOperand} by {secondOperand} that will equal {quotient}");

            Console.WriteLine();

            var remainder = secondOperand % firstOperand;

            Console.WriteLine($"The remainder of {secondOperand} and {firstOperand}");

            Console.WriteLine();

            Console.WriteLine($"{userName}, thanks for playing!");












            Console.WriteLine("Welcome to C#");
        }
    }
}

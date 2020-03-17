using System;



namespace Calc
{
    class Calc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the desired equation (+-/*) using the following format: n O n, where 'n' stand for number and 'O' for operation e.g 3 + 4");
            string equationInput = Console.ReadLine();
            string[] eq = { equationInput };

            if (Validation.isValidEquation(eq[0]) == true)
            {
                Console.WriteLine($"'{eq[0]}' is a valid equation, starting calcualtion process bzzzz");
                eq = equationInput.Split(' ');
                switch (eq[1])
                {
                    case "+":
                        Console.WriteLine(MathematicalOperations.Add(Int16.Parse(eq[0]), Int16.Parse(eq[2])));
                        break;
                    case "-":
                        Console.WriteLine(MathematicalOperations.Substract(Int16.Parse(eq[0]), Int16.Parse(eq[2])));
                        break;

                    case "*":
                        Console.WriteLine(MathematicalOperations.Multiply(Int16.Parse(eq[0]), Int16.Parse(eq[2])));
                        break;
                    case "/":
                        Console.WriteLine(MathematicalOperations.Divide(Int16.Parse(eq[0]), Int16.Parse(eq[2])));
                        break;
                }

            }

            else
            {
                Console.WriteLine($"'{eq[0]}' is not a valid equation, try again.");
            }

        }

    }
}
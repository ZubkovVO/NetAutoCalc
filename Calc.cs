using System;
using System.Text.RegularExpressions;

//Replace()

namespace Calc
{
    class Calc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the desired equation (+-/*) using the following format: n O n, where 'n' stand for number and 'O' for operation e.g 3 + 4");
            string equationInput = Console.ReadLine();
            string[] eq = { equationInput };
            string n1 = eq[0];

            Console.WriteLine($"{n1} {(isValidEquation(n1) ? "is" : "is not")} a valid equation.");

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

        public static bool isValidEquation(string inputEquation)
        {
            string strRegex = @"\d+\s[*+/-]\s\d+";
            Regex re = new Regex(strRegex);
            return re.IsMatch(inputEquation);
        }

    }
}
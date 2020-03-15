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
            //string[] eq = input.Split(' ');   Массив

            foreach (var number in eq)
            {
                Console.WriteLine($"<{number}>");
            }
            var checkArr = eq.GetLength(0);
            Console.WriteLine(checkArr);

            if (checkArr > 3)
            {
                Console.WriteLine("Incorrect number of parameters - " + checkArr + " Please refer to the example: 1 + 1");
            }
            else
            {
                string n1 = eq[0];
                // string o1 = eq[1];
                // string n2 = eq[2];

                Console.WriteLine($"{n1} {(isValidNumber(n1) ? "is" : "is not")} a valid number.");
                //Console.WriteLine("{0} {1} a valid operator.",o1, isValidOperator(o1) ? "is" : "is not");
                // Console.WriteLine("{0} {1} a valid number.",n2, isValidNumber(n2) ? "is" : "is not");

            };



            //int.TryParse(number1, out var newVariable);

            //Console.ReadKey();



        }

        public static bool isValidNumber(string inputEquation)
        {
            string strRegex = @"\d+\s[*+/-]\s\d+";

            //@"^((?:((-?\d+)(,\d+)?)+[*+/-])+((-?\d+)(,\d+)?)+)|^(-?\d+)(\.\d+)?$";

            // 

            Regex re = new Regex(strRegex);

            return re.IsMatch(inputEquation);

        }

        public static bool isValidOperator(string inputEquation)
        {
            //string strRegex = @"[-*\+]";

            Regex re = new Regex(@"[-*+/]" + "[0-9]");

            if (re.IsMatch(inputEquation))
                return (true);
            else
                return (false);
        }

    }
}
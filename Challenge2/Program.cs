using System;
/*
Create a function taking a positive integer as its parameter and returning a string containing the
Roman Numeral representation of that integer.

Modern Roman numerals are written by expressing each digit separately starting with the left
most digit and skipping any digit with a value of zero. In Roman numerals 1990 is rendered:
10002M, 900=CM, 90=XC; resulting in MCMXC. 2008 is written as 2000=MM, 8=Vlll; or MMVIII.
1666 uses each Roman symbol in descending order: MDCLXVI.

Example:

RomanConvert.Solution(1000) -- should return "M"
Help:
Symbol Value

    I   1
    V   5
    X   10
    L   50
    C   100
    D   500
    M   1000

Remember that there can't be more than 3 identical symbols in a row.
More about roman numerals - http://en.wikipedia.org/wiki/Roman numerals
*/

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                if (!ExecChallenge2())
                    break;
                Console.Clear();
            }
            
        }

        /**
         * This method solves the Challenge, and returns a boolean value indicating if the user wants to restart the
         * application.
         */
        static bool ExecChallenge2()
        {
            Console.WriteLine("Welcome to Challenge 2: Roman Numeral");
            Console.WriteLine(new string('-', 50));
            Console.Write("Insert the integer number you desire to convert to a roman numeral: ");
            var numberAsText = Console.ReadLine();
            Console.Write("Answer: ");

            Console.WriteLine(
                int.TryParse(numberAsText, out int number)
                ? RomanConvert.Solve(number)
                : "You didn't type a valid integer number"
            );

            Console.Write("\nDo you want to type another number? [y]: ");
            return Console.ReadLine() == "y";

        }
    }
}

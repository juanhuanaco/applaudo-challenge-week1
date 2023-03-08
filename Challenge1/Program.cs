using System;

/*
 
Write a function that takes a string of parentheses, and determines if the order of the parentheses
is valid. The function should return true if the string is valid, and false if it's invalid.

Examples
   "()" => true
   ")(()))" => false
   "(" => false
   "(())((()())())" => true

Constraints
0 <= input.length <= 100
 
Along with opening (() and closing ()) parenthesis, input may contain any valid ASCII characters.
Furthermore, the input string may be empty and/or not contain any parentheses at all. Do not
treat other forms of brackets as parentheses (e.g. [], {}, <>). 
*/

namespace Challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                if (!ExecChallenge1())
                    break;
                Console.Clear();
            }
            
        }

        /**
         * This method solves the Challenge, and returns a boolean value indicating if the user wants to restart the
         * application.
         */
        private static bool ExecChallenge1()
        {

            // For this challenge i thought of two solutions, one with a counter and the other using regex.
            Console.WriteLine("Welcome to Challenge 1: Parenthesis order checking");
            Console.WriteLine(new string('-', 50));
            Console.Write("Input the text to evaluate: ");
            var text = Console.ReadLine() ?? "";
            Console.Write("\nResult: ");

            // We check the size constraint.
            if ( !(text.Length > 100) )
            {
                //Here we can change between Solution1 or Solution2
                var result = Solve.UsingSolution(new Solution1(), text); //new Solution1() or new Solution2()
                Console.WriteLine(
                    result
                    ? "VALID order of parenthesis. Nice!"
                    : "INVALID order of parenthesis. Needs a check!"
                );
            }
            else
                Console.WriteLine("You exceeded 100 characters...");
            
            Console.Write("Do you want to validate another text ? [y]: ");
            return Console.ReadLine() == "y";
        }
    }

    class Solve
    {
        public static bool UsingSolution(ISolutionChallenge1 solution, string text)
        {
            return solution.Resolve(text);
        }
    }
}

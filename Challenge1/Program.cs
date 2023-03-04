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
                if (!Initiate())
                    break;
                Console.Clear();
            }
            
        }

        private static bool Initiate()
        {

            // For this challenge i thought of two solutions, one with a counter and the other using regex.
            Console.WriteLine("Challenge 1: Evaluate order of parenthesis");
            Console.WriteLine(new string('-', 50));
            Console.Write("Input the text to evaluate: ");
            string text = Console.ReadLine();

            // We check the size constraint.
            if (text.Length > 100)
            {
                Console.WriteLine("Excediste los 100 caracteres...");
                return true;
            }

            //Here we can change between Solution1 or Solution2
            Console.Write("\nResult: ");
            bool result = Solve.UsingSolution(new Solution2(), text); //new Solution1() or new Solution2()
            if (result)
                Console.WriteLine("VALID order of parenthesis. Nice!");
            else
                Console.WriteLine("UNVALID order of parenthesis. Needs a check!");

            Console.Write("Do you want to validate another text ? [y]: ");
            return Console.ReadLine() == "y" ? true : false;
            
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

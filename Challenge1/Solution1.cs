using System;

namespace Challenge1
{
    internal class Solution1 : ISolutionChallenge1
    {
        public bool Resolve(string text)
        {
            if ( !(text.Contains("(") || text.Contains(")")) ) return false;

            byte counter = 0;
            foreach(char letter in text)
            {
                if (letter == '(')
                    counter++;
                else if (letter == ')')
                    counter--;

                if (counter == 255) // -1 = 255 Overflowing
                    return false;
            }
            return counter == 0;
        }
    }
}

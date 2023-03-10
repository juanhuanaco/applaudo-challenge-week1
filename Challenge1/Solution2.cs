using System;
using System.Text.RegularExpressions;

namespace Challenge1
{
    internal class Solution2 : ISolutionChallenge1
    {
        public bool Resolve(string text)
        {
            if ( !(text.Contains("(") || text.Contains(")")) ) return false;

            text = CleanString(text);
            var rx = new Regex(@"\(\)");
            while(true)
            {
                if (rx.IsMatch(text))
                    text = rx.Replace(text, "");
                else
                    break;
            }
            return text.Length == 0;
        }

        //Removes characters other than ( or )
        private string CleanString (string dirtyString)
        {
            var cleanedString = "";
            foreach(char letter in dirtyString)
            {
                if(letter == '(' || letter == ')')
                    cleanedString += letter;
            }
            return cleanedString;
        }

    }
}

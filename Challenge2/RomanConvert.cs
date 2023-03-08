using System;
using System.Text;

namespace Challenge2
{
    internal class RomanConvert
    {
        public static string Solve(int number)
        {
            if (number > 3999 || number < 1)
                return "The number must be between 1 and 3999 (both inclusive).";

            var modifiedNumber = $"{number}".ToCharArray();
            Array.Reverse(modifiedNumber);

            var letterOnes = new[] { 'I', 'X', 'C', 'M' };
            var letterFives = new[] { 'V', 'L', 'D' };
            var romanNumber = new StringBuilder();

            for (int i = 0; i < modifiedNumber.Length; i++)
            {
                switch (modifiedNumber[i])
                {
                    case '1':
                        romanNumber.Insert(0, letterOnes[i]); break;
                    case '2':
                        romanNumber.Insert(0, new string(letterOnes[i], 2)); break;
                    case '3':
                        romanNumber.Insert(0, new string(letterOnes[i], 3)); break;
                    case '4':
                        romanNumber.Insert(0, $"{letterOnes[i]}{letterFives[i]}"); break;
                    case '5':
                        romanNumber.Insert(0, letterFives[i]); break;
                    case '6':
                        romanNumber.Insert(0, $"{letterFives[i]}{letterOnes[i]}"); break;
                    case '7':
                        romanNumber.Insert(0, $"{letterFives[i]}{new string(letterOnes[i], 2)}"); break;
                    case '8':
                        romanNumber.Insert(0, $"{letterFives[i]}{new string(letterOnes[i], 3)}"); break;
                    case '9':
                        romanNumber.Insert(0, $"{letterOnes[i]}{letterOnes[i + 1]}"); break;
                }
            }
            return romanNumber.ToString();
        }
    }
}

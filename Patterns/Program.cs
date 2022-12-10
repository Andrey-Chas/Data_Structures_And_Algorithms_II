using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "this is a text";
            char[] textAsCharArr = text.ToCharArray();
            string pattern = "* is a tex?";
            char[] patternAsCharArr = pattern.ToCharArray();
            Console.WriteLine(MatchPattern(textAsCharArr, patternAsCharArr, textAsCharArr.Length - 1, patternAsCharArr.Length - 1));
        }

        private static bool MatchPattern(char[] text, char[] pattern, int textIndex, int patternIndex)
        {
            if (textIndex < 0 && patternIndex < 0)
            {
                return true;
            }
            if (patternIndex < 0)
            {
                return false;
            }
            if (textIndex < 0 && pattern[patternIndex] == '*')
            {
                return true;
            }
            if (text[textIndex] == pattern[patternIndex] || pattern[patternIndex] == '?')
            {
                return MatchPattern(text, pattern, textIndex - 1, patternIndex - 1);
            }
            else if (pattern[patternIndex] == '*')
            {
                return MatchPattern(text, pattern, textIndex - 1, patternIndex) ||
                    MatchPattern(text, pattern, textIndex, patternIndex - 1);
            }
            else
            {
                return false;
            }
        }
    }
}

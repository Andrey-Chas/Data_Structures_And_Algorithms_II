using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Count_Words_In_The_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\диан\source\repos\Data_Structures_And_Algorithms_II\Count_Words_In_The_Book\CaptainBlood.txt";

            CountWords(file);
        }

        private static void CountWords(string file)
        {
            Dictionary<string, int> wordNumber = new Dictionary<string, int>();
            string separator = ",.!;?“”:/â€$?()[]%{}*&#|_œ'-1234567890";
            string notNeedCharWord = " a b c d e f g h i j k l m n o p q r s t u v w x y z I II III IV V VI VII VIII IX X XI XII XIII XIV XV XVI XVII XVIII XIX XX XXI XXII XXIII XXIV XXV XXVI XXVII XXVIII XXIX XXX XXXI and or with the of before after at on an by this that he her she his it theirs its their for those from to between among you we us them mine yours your in out him they me my de m mr mrs";
            char[] separatorAsChar = separator.ToCharArray();
            string[] notNeedCharWordAsArr = notNeedCharWord.Split();

            string book = File.ReadAllText(file);
            char[] bookAsChar = book.ToCharArray();
            StringBuilder sb = new StringBuilder();

            foreach (var character in bookAsChar)
            {
                int count = 0;
                for (int i = 0; i < separatorAsChar.Length; i++)
                {
                    if (character != separatorAsChar[i])
                    {
                        count++;
                        if (count == separatorAsChar.Length)
                        {
                            sb.Append(character);
                        }
                    }
                    else
                    {
                        sb.Append(" ");
                        break;
                    }
                }
            }
            string bookAsStr = sb.ToString();
            string[] bookAsArr = bookAsStr.Trim().Split();

            foreach (var word in bookAsArr)
            {
                if (!wordNumber.ContainsKey(word.ToLower()))
                {
                    wordNumber.Add(word.ToLower(), 1);
                }
                else
                {
                    wordNumber[word.ToLower()] = wordNumber[word.ToLower()] + 1;
                }
            }

            for (int i = 0; i < notNeedCharWordAsArr.Length; i++)
            {
                if (wordNumber.ContainsKey(notNeedCharWordAsArr[i].Trim().ToLower()))
                {
                    wordNumber.Remove(notNeedCharWordAsArr[i].Trim().ToLower());
                }
            }

            List<KeyValuePair<string, int>> sortedWordNumber = wordNumber.OrderBy(a => a.Value).ToList();

            Console.WriteLine("20 most used words in the book:");
            for (int i = sortedWordNumber.Count - 1; i > sortedWordNumber.Count - 20; i--)
            {
                Console.WriteLine($"Word: {sortedWordNumber.ElementAt(i).Key} -> {sortedWordNumber.ElementAt(i).Value}");
            }

            Console.WriteLine();
            Console.WriteLine("20 least used words in the book:");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Word: {sortedWordNumber.ElementAt(i).Key} -> {sortedWordNumber.ElementAt(i).Value}");
            }
        }
    }
}

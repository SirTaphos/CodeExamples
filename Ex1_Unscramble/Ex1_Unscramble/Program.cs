using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Ex1_Unscramble
{
    class Program
    {
        static void Main(string[] args)
        {
           string output = null;
           var m = new Methods();
           var scrambledWordsList = new List<string>
           {
               "estntbi",
               "mcapoq",
               "arseac",
               "lesrlsu",
               "etrtag",
               "olrsfew",
               "anonrm",
               "woocom",
               "hnonyj",
               "yactnih"
           };

            foreach (var scrambledWord in scrambledWordsList)
            {
                output += m.UnscrambleWord(scrambledWord) + ",";
            }

            Console.WriteLine(output);
            Console.ReadLine();
        }
    }

    internal class Methods
    {
        // Iterate thorugh the list and unscramble the words
        public string UnscrambleWord(string scrambledWord)
        {
            var wordsList = LoadList();
            foreach (var word in wordsList)
            {
                var splitWord = SplitWord(word);
                var splitScrambledWord = SplitWord(scrambledWord);

                if (AssembleWord(splitWord) == AssembleWord(splitScrambledWord))
                {
                    return word;
                }
            }
            return null;
        }

        // Load the wordsList into the program in a list
        private static IEnumerable<string> LoadList()
        {
            string line;
            var wordsList = new List<string>();
            var file = new StreamReader(@"W:\PCPROG\_BJP\Hacking\wordlist.txt");
            while ((line = file.ReadLine()) != null)
            {
                wordsList.Add(line);
            }
            file.Close();
            return wordsList;
        }

        private static char[] SplitWord(string word)
        {
            return string.Concat(word.OrderBy(c => c)).ToCharArray();
        }

        private static string AssembleWord(char[] word)
        {
            return new string(word);
        }
    }
}

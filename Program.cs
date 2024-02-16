using System;
using System.Linq;

namespace nodups
{
    class Program
    {
        private static string NoDup(string phrase)
        {
            const string yes = "yes";
            const string no = "no";
            const int maxPhraseLength = 80;
            bool isEmpty = string.IsNullOrWhiteSpace(phrase);
            
            // If the phrase is empty or if the phrase
            // is longer than 80 chars, return no
            if (isEmpty || phrase.Length > maxPhraseLength) {
                return no;
            }

            // Remove all whitespace and split the string into an array 
            string[] words = phrase.Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            
            // Check if all words are distinct and if all characters are upper case
            bool allWordsDistinct = words.Length == words.Distinct().Count();
            bool allCharactersUpperCase = words.All(word => word.All(char.IsUpper));
            
            return allWordsDistinct && allCharactersUpperCase ? yes : no;
        }

        private static void PrintResult(string phrase)
        {
            Console.WriteLine(NoDup(phrase));
        }

        static void Main()
        {   
            // This works in Visual Studio but not Kattis
            /*for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter a phrase:");
                string? phrase = Console.ReadLine();
                if (phrase != null) PrintResult(phrase);
            }
            */
            /* Also works in visual studio but not Kattis
            const string phrase0 = "THE RAIN IN SPAIN";
            const string phrase1 = "IN THE RAIN AND THE SNOW";
            const string phrase2 = "THE RAIN IN SPAIN IN THE PLAIN";
            PrintResult(phrase0);
            PrintResult(phrase1);
            PrintResult(phrase2);
            */
           
            // This works in Kattis for one test case
            const string phrase0 = "THE RAIN IN SPAIN";
            PrintResult(phrase0);
        }
    }



}
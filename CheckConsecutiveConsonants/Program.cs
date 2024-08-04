using System;
using System.Linq;

namespace CheckConsecutiveConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen string ifadeleri girin (örneğin: Merhaba Umut Arya):");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');

            foreach (var word in words)
            {
                bool hasConsecutiveConsonants = ContainsConsecutiveConsonants(word);
                Console.Write(hasConsecutiveConsonants + " ");
            }

            Console.WriteLine("\nDevam etmek için bir tuşa basın...");
            Console.ReadKey();
        }

        static bool ContainsConsecutiveConsonants(string word)
        {
            if (word.Length < 2)
                return false;

            string vowels = "aeiouAEIOU";

            for (int i = 0; i < word.Length - 1; i++)
            {
                char currentChar = word[i];
                char nextChar = word[i + 1];

                if (!vowels.Contains(currentChar) && !vowels.Contains(nextChar))
                {
                    return true;
                }
            }

            return false;
        }
    }
}

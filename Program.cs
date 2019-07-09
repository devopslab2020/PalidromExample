using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalidromeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalidrome("Deleveled"));
            Console.ReadLine();
        }

        public static bool IsPalidrome(string word)
        {
            string originalWord = word.ToLower();
            char[] wordArray = word.ToLower().ToCharArray();
            Array.Reverse(wordArray);

            string reversedWord = new string(wordArray);

            if (originalWord.Equals(reversedWord))
                return true;
            else
                return false;
        }
    }
}

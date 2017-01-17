using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a word you would like translated");
            string input = Console.ReadLine();
            char[] wordIn = input.ToCharArray();
            var firstLetter = Char.ToLower(wordIn[0]);
            var secondLetter = Char.ToLower(wordIn[1]);
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            if (vowels.Contains(firstLetter)) //first letter is vowel
            {
                Console.WriteLine($"{input}way");
                Console.ReadLine();
            }
            else if (vowels.Contains(secondLetter)) //First letter is Consanant, 2nd is vowel
            {
                Console.WriteLine($"{input.Substring(1, input.Length - 1)}{firstLetter}ay");
                Console.ReadLine();
            }
            else //Neither the first or second letters are vowels
            {
                Console.WriteLine($"{input.Substring(2, input.Length - 2)}{firstLetter}{secondLetter}ay");
                Console.ReadLine();
            }
        }
    }
}


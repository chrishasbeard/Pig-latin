using System;

namespace Capstone_PigLatin
{
    class Program
    {        
        public static char[] vowels = "aeiou".ToCharArray();
        static void Main(string[] args)
        {           
            Console.WriteLine("Welcome to the pig latin translator!");
            Console.Write("Please enter a sentence to be translated: ");
            string word = Console.ReadLine();
            int index = 0;
            if (StartsWithVowel(word) == true)
                {
                Console.Write(word + "way");
                }
            else 
                {
                DoesNotStartWithVowel(word);
                }
            
            for(int i =0; i< vowels.Length; i++)
                {
                if (word.StartsWith(vowels[i]))
                    {
                        Console.WriteLine(word + "way");
                    }
                }
            index = word.IndexOfAny(vowels);

            string firstPart = word.Substring(index);
            string secondPart = word.Substring(0, index);
            Console.WriteLine(firstPart + secondPart + "ay");
        }
        public static string DoesNotStartWithVowel(string word)
        {

        }
        public static bool StartsWithVowel(string word)
        {
            for (int i = 0; i < vowels.Length; i++)
            {
                if (word.StartsWith(vowels[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

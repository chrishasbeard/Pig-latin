using System;
namespace Test
{
    class Program
   {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to the pig latin translator!");

            do
            {
                Console.WriteLine("Please enter what you want translated:");
                string english = Console.ReadLine();
                english.ToLower();
                string pigLatin = "";
                string firstLetter;
                string restOfWord;
                string vowels = "aeiou";
                int letterPos;
                foreach (string word in english.Split())
                {
                    firstLetter = word.Substring(0, 1);
                    restOfWord = word.Substring(1, word.Length - 1);
                    letterPos = vowels.IndexOf(firstLetter);
                    if (letterPos == -1)
                    {
                        pigLatin = restOfWord + firstLetter + "ay ";
                    }
                    else
                    {
                        pigLatin = word + "way ";
                    }
                    Console.Write(pigLatin);
                }                
            }
            while (KeepGoing() == true);
           
        }
        public static bool KeepGoing()
        {
            Console.WriteLine("\nDo you wish to continue? (y/n): ");
            string question = Console.ReadLine();
            switch (question)
            {
                case "y":
                    return true;
                case "n":
                    return false;
                default:
                    return KeepGoing();
            }
        }
    }
}

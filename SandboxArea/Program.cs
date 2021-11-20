using System;

namespace SandboxArea
{
    class Program
    {

        static int HowManyCharacters(string word)
        {
            int charactersInWord = word.Length;
            return charactersInWord;
        }


        static bool ContainsApostrophe(string word)
        {
            bool hasApostrophe = word.Contains("'");
            if (hasApostrophe == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static void Main(string[] args)
        {
            int howManyCharacters = HowManyCharacters("Citadel");
            Console.WriteLine(howManyCharacters);

            bool testingMyMethod = ContainsApostrophe("don't");
            Console.WriteLine(testingMyMethod);
        }
    }
}

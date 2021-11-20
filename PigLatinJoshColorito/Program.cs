using System;

namespace PigLatinJoshColorito
    
    // MAIN REQUIREMENTS
    // 1 POINT: Prompts the user for a word. --- COMPLETE
    // 1 POINT: Translate the text to Pig Latin and displays it on the console. --- COMPLETE
    // 1 POINT: Asks the user if they would like to translate another word. --- COMPLETE
    // 1 POINT: Convert each word to a lowercase before translating. --- COMPLETE
    // 1 POINT: If a word starts with a vowel, just add "way" on to the ending. --- COMPLETE
    // 2 POINTS: If a word starts with a consonant, move all of the consonants that appear before the first vowel to the end of the word and then add "ay" to the end of the word. --- COMPLETE
    // 1 POINT: Answering the Lab Summary when submitting to LMS.
    
    // EXTENDED EXERCISES (2 points max)
    // 1 POINT: Allow punctuation in the input string.
    // 1 POINT: Translates words with contractions (ex: can't --> ant'cay)
    // 1 POINT: Don't translate words that have numbers or symbols (ex: 189 should be left as 189 and hello@grandcircus.co should be left as hello@grandcircus.co)
    // 1 POINT: Check that the user has actually entered text before translating.
    // 1 POINT: Make the application take aline instead of a single word, and then find the Pig Latin for each word in the line.
    
    // HINTS
    // Treat "y" as a consonant





    ////////////////////////////////////////////// I THINK I SHOULD SAVE THIS AS THE "BASE" FILE AND THEN CREATE ANOTHER VERSION OF THIS FOR THE EXTENDED ASSIGNMENTS ///////////////////////



{
    class Program
    {
        static char GetFirstLetter(string word)
        {
            char firstLetter = word[0];
            return firstLetter;
        }

        static bool IsVowel(char letter)
        {

            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool ContainsApostrophe(string word)
        {
            bool hasApostrophe = word.Contains("'");
            if (hasApostrophe)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string PigLatin(string word)
        {
            string wordEntered = word.ToLower();
            char firstLetter = GetFirstLetter(word);

            if (IsVowel(firstLetter))
            {
                string pigLatinBeginsWithVowel = wordEntered + "way";
                return pigLatinBeginsWithVowel;
            }
            else
            {
                int indexOfFirstVowel = -1;
                for (int i = 0; i < wordEntered.Length; i++)
                {
                    if (IsVowel(wordEntered[i]))
                    {
                        indexOfFirstVowel = i;
                        break;
                    }
                }
                int numOfConsonantsBeforeVowel = indexOfFirstVowel;
                string consonantSubstring = word.Substring(0, numOfConsonantsBeforeVowel);
                string lettersAfterFirstVowel = wordEntered.Substring(indexOfFirstVowel);
                string pigLatinDoesNotBeginWithVowel = lettersAfterFirstVowel + consonantSubstring + "ay";
                return pigLatinDoesNotBeginWithVowel;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter a word: ");
            string wordEntered = Console.ReadLine().ToLower();
            int lengthOfWordEntered = wordEntered.Length;

            while (lengthOfWordEntered < 1)
            {
                Console.Write("You did not enter a word. Please enter your word here: ");
                wordEntered = Console.ReadLine().ToLower();
                lengthOfWordEntered = wordEntered.Length;
            }


            string pigLatinWord = PigLatin(wordEntered);
            Console.WriteLine("Your word translated into Pig Latin is: " + pigLatinWord);

            Console.Write("Would you like to enter another word? (Y/N): ");
            string goAgain = Console.ReadLine();

            if (goAgain == "Y")
            {
                do
                {
                    Console.Write("\nPlease enter another word: ");
                    wordEntered = Console.ReadLine().ToLower();
                    lengthOfWordEntered = wordEntered.Length;

                    while (lengthOfWordEntered < 1)
                    {
                        Console.Write("You did not enter a word. Please enter your word here: ");
                        wordEntered = Console.ReadLine().ToLower();
                        lengthOfWordEntered = wordEntered.Length;
                    }

                    pigLatinWord = PigLatin(wordEntered);
                    Console.WriteLine("Your next word translated into Pig Latin is: " + pigLatinWord);
                    Console.Write("Would you like to enter another word? (Y/N): ");
                    goAgain = Console.ReadLine();
                } while (goAgain == "Y");
            }
            Console.WriteLine("\nThe application will now terminate. Goodbye!");
        }
    }
}

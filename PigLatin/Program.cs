using System;

namespace PigLatin
{
    class Program
    {
        // This method ultimately returns a STRING
        // When the function is called, the user needs to enter a word
        // Inside the function, it takes the index of the first letter of the word they pass in (in this case, [0]) and passes that into a CHAR variable called firstLetter
        // The method then parses firstLetter to a string with the .ToString() function and returns that string value to where the function was called
        static string GetFirstLetter(string word)
        {
            char firstLetter = word[0];
            return firstLetter.ToString();
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

        static string PigLatin(string word)
        {
            string wordEntered = word.ToLower();
            string pigLatinFirstLetter = GetFirstLetter(word);

            if (pigLatinFirstLetter == "a" || pigLatinFirstLetter == "e" || pigLatinFirstLetter == "i" || pigLatinFirstLetter == "o" || pigLatinFirstLetter == "u")
            {
                return wordEntered + "way";
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

                int numOfConsonantsBeforeFirstVowel = indexOfFirstVowel;
                string consonantSubstring = wordEntered.Substring(0, numOfConsonantsBeforeFirstVowel);

                string testingSomething = wordEntered.Substring(indexOfFirstVowel);
                return testingSomething + consonantSubstring + "ay";
            }
        }


        static void Main(string[] args)
        {
            /* ----- DIRECTIONS -----
             * Intro: Pig Latin is a children's word game in English where starting consonants are flipped to the ends of words and -ay is added to each word.
             *        For instance, Hello World would be ellohay orldway in Pig Latin.
             *        Many languages have similar games to this.
             *        
             * Task: Translate from English to pig latin.
             * 
             * ----- WHAT WILL THE APPLICATION DO? -----
             * 1 POINT: Prompts the user for a word. --- COMPLETE
             * 1 POINT: Translates the text to Pig Latin and displays it on the console. --- COMPLETE
             * 1 POINT: Asks the user if they would like to translate another word.
             * 
             * ----- BUILD SPECIFICATIONS -----
             * 1 POINT: Convert each word to a lowercase before translating. --- COMPLETE
             * 1 POINT: If a word starts with a vowel, just add "way" on to the ending. --- COMPLETE
             * 2 POINTS: If a word starts with a consonant, move all of the consonants that appear before the first vowel to the end of the word, then add "ay" to the end of the word. --- COMPLETE
             * 
             * ----- ADDITIONAL REQUIREMENTS -----
             * 1 POINT: For answering the Lab Summary when submitting to the LMS
             * -2 POINTS: If there are any syntax errors or if the program does not run
             * 
             * ----- EXTENDED EXERCISES (2 points maximum) -----
             * 1 POINT: Keep the case of the word, whether it's uppercase (WORD), title case (Word), or lowercase (word).
             * 1 POINT: Allow punctuation in the input string.
             * 1 POINT: Translate words with contractions (ex: can't --> ant'cay).
             * 1 POINT: Don't translate words that have numbers or symbols (ex: 189 should be left as 189 and hello@grandcircus should be left as hello@grandcircus.co).
             * 1 POINT: Check that the user has actually entered text before translating.
             * 1 POINT: Make the application take a line instead of a single word, and then find the Pig Latin for each word in the line.
             * 
             * ---- HINTS ----
             * Treat "y" as a consonant
             */

           

            // Asks user to enter a word
            // The word they entered is passed to the Console.ReadLine() function and then is transformed into lowercase with .ToLower()
            // That result is then stord in a STRING called wordEntered
            Console.Write("Please enter a word: ");
            string wordEntered = Console.ReadLine().ToLower();
           

            string pigLatinWord = PigLatin(wordEntered);
            Console.WriteLine("Your word translated to Pig Latin is: " + pigLatinWord);


            Console.Write("Would you like to enter another word? (Y/N): ");
            string userResponse = Console.ReadLine();

            if (userResponse == "Y")
            {
                do
                {
                    Console.WriteLine("\n");
                    Console.Write("Please enter another word: ");
                    wordEntered = Console.ReadLine();
                    pigLatinWord = PigLatin(wordEntered);
                    Console.WriteLine("Your next word translated into Pig Latin is: " + pigLatinWord);
                    Console.Write("Would you like to enter another word? (Y/N): ");
                    userResponse = Console.ReadLine();
                } while (userResponse == "Y");
            }

            Console.WriteLine("\nThe application will now terminate. Goodbye!");

        }
    }
}

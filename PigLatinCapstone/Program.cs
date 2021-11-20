using System;

namespace PigLatinCapstone
{
    class Program
    {
        // Returns the first letter of the word that is entered into this function as a STRING
        static string GetFirstLetter(string word)
        {
            char firstLetter = word[0];
            return firstLetter.ToString();
        }


        // Checks if the letter entered is a vowel and returns a BOOLEAN vale
        // If it is a vowel, it returns True
        // If it is not a vowel, it returns False
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

        // Checks if the word entered contains an apostrophe and returns a BOOLEAN value
        // If there is an apostrophe in the word, it returns True
        // If there is no apostrophe in the word, it returns False
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

        static bool ContainsInvalidCharacter(string word)
        {
            bool invalidCharacter = word.Contains('!');
            if (invalidCharacter == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool MoreThanOneWord(string word)
        {
            bool phrase = word.Contains(" ");
            if (phrase == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // Converts a word entered into Pig Latin
        static string PigLatin(string word) // (string word) is the value passed into PigLatin()
        {
            string wordEntered = word.ToLower(); // Takes the word entered, converts it to lowercase, and then stores that value in a new STRING called wordEntered.
            string pigLatinFirstLetter = GetFirstLetter(word); // Calls the GetFirstLetter function and fills it with the word passed into the Pig Latin Function. It then stores the value in a new STRING called pigLatinFirstLetter.
            bool hasApostrophe = ContainsApostrophe(word); // Calls the ContainsApostrophe function and fills it with the word passed into the Pig Latin Function. It then stores the value in a new BOOLEAN called hasApostrophe.
            int indexOfFirstVowel = -1; // I'M CAPITALIZING THIS BECAUSE I AM HONESTLY NOT SURE WHY THIS IS INITIALIZED TO -1 // This is called de-referencing or v-referencing?? It's a way of making sure you get something back from the function


            if (pigLatinFirstLetter == "a" || pigLatinFirstLetter == "e" || pigLatinFirstLetter == "i" || pigLatinFirstLetter == "o" || pigLatinFirstLetter == "u") // Checks to see if pigLatinFirstLetter contains a vowel.
            {
                return wordEntered + "way"; // If the first letter is a vowel, it returns wordEntered + "way" as a STRING
            }
            else if (hasApostrophe == true) // If the first letter does not contain a vowel, it then checks if there's an apostrophe in the word. If there is, it executes the else-if statement shown below to check for the location of the first vowel.
            {
                // Checks if the index position 0 of wordEntered is a vowel and stores that in a boolean.
                for (int i = 0; i < wordEntered.Length; i++)
                {
                    if (IsVowel(wordEntered[i])) // If IsVowel() is True, the value of i is stored in indexOfFirstVowel. It then breaks the loop early.
                    {
                        indexOfFirstVowel = i;
                        break; // If IsVowel() is False, the loops keeps running (and incrementing i by one unit) until it finds a vowel.
                    }
                }
                int numOfConsonantsBeforeFirstVowel = indexOfFirstVowel; // After the loop has exited, the value of indexOfFirstVowel is stored in a new INT called numOfConsonantsBeforeFirstVowel
                string consonantSubstring = wordEntered.Substring(0, numOfConsonantsBeforeFirstVowel); // This line stores whatever the consonants are before the first vowel as a new STRING called consonantSubstring.
                string lettersAfterFirstVowel = wordEntered.Substring(indexOfFirstVowel); // This line captures and stores all of the letters contained in the word after the first vowel as a new STRING called lettersAfterFirstVowel.
                return lettersAfterFirstVowel + consonantSubstring + "ay"; // Concatenates the values of lettersAfterFirstVowel + consonantSubstring + "ay" and returns the result as a STRING
            }
            else // If the first letter does not contain a vowel and the word also does not contain an apostrophe, it executes the else statement shown below to check for the location of the first vowel (it's basically the same thing as above)
            {

                for (int i = 0; i < wordEntered.Length; i++) // This for loop will check the length of the word that was entered into PigLatin() and then run that many times
                {

                    // Checks if the index position 0 of wordEntered is a vowel and stores that in a boolean.
                    if (IsVowel(wordEntered[i])) 
                    {
                        indexOfFirstVowel = i; // If IsVowel() is True, the value of i is stored in indexOfFirstVowel. It then breaks the loop early.
                        break;
                    }

                } // If IsVowel() is False, the loops keeps running (and incrementing i by one unit) until it finds a vowel.

                int numOfConsonantsBeforeFirstVowel = indexOfFirstVowel; // After the loop has exited, the value of indexOfFirstVowel is stored in a new INT called numOfConsonantsBeforeFirstVowel
                string consonantSubstring = wordEntered.Substring(0, numOfConsonantsBeforeFirstVowel); // This line stores whatever the consonants are before the first vowel as a new STRING called consonantSubstring.
                string lettersAfterFirstVowel = wordEntered.Substring(indexOfFirstVowel); // This line captures and stores all of the letters contained in the word after the first vowel as a new STRING called lettersAfterFirstVowel.
                return lettersAfterFirstVowel + consonantSubstring + "ay"; // Concatenates the values of lettersAfterFirstVowel + consonantSubstring + "ay" and returns the result as a STRING
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
             * 1 POINT: Asks the user if they would like to translate another word. --- COMPLETE
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
             * 1 POINT: Keep the case of the word, whether it's uppercase (WORD), title case (Word), or lowercase (word). // JEFF SAID NOT TO WORRY ABOUT THIS ONE SO DON'T DO IT.
             * 1 POINT: Allow punctuation in the input string. --- COMPLETE
             * 1 POINT: Translate words with contractions (ex: can't --> ant'cay). --- COMPLETE
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


            /* bool isThereInvalidCharacter = ContainsInvalidCharacter(wordEntered);

            do
            {
                if (isThereInvalidCharacter == true)
                {
                    Console.Write("You entered a word with an invalid character. Please enter another value: ");
                    wordEntered = Console.ReadLine().ToLower();
                    isThereInvalidCharacter = ContainsInvalidCharacter(wordEntered);
                }
            } while (isThereInvalidCharacter == true);
            */

            
            
            /* do
            {
                if (wordEntered == null)
                {
                    Console.Write("You did not enter a value. Please enter a word: ");
                    wordEntered = Console.ReadLine().ToLower();
                }
            } while (wordEntered == null);
            */
            




                     
           

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

// It said there's only 2 points maximum on the extra credit :|
// Ask about why int indexOfFirstVowel is initialized to -1
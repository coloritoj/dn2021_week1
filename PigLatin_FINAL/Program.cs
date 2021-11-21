using System;

namespace PigLatin_FINAL
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

        static bool ContainsSpace(string entry)
        {
            bool multipleWords = entry.Contains(" ");
            if (multipleWords)
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
            Console.Write("Please enter a word or phrase: ");
            string wordEntered = Console.ReadLine().ToLower();
            int lengthOfWordEntered = wordEntered.Length;

            while (lengthOfWordEntered < 1)
            {
                Console.Write("You did not enter a word or phrase. Please enter it here: ");
                wordEntered = Console.ReadLine().ToLower();
                lengthOfWordEntered = wordEntered.Length;
            }

            // Start of experiment


            if (ContainsSpace(wordEntered))
            {
                string lowerCaseMyWords = wordEntered.ToLower();
                string[] arrayTest = lowerCaseMyWords.Split(' ');

                Console.Write("Your phrase translated to Pig Latin is: ");
                foreach (string word in arrayTest)
                {
                    Console.Write(PigLatin(word).ToLower() + " ");
                }
                Console.Write("\nWould you like to enter another word or phrase? (Y/N): ");
                string enterNewWord = Console.ReadLine();

                if (enterNewWord == "Y")
                {
                    do
                    {
                        Console.Write("\nPlease enter another word or phrase: ");
                        wordEntered = Console.ReadLine().ToLower();
                        lengthOfWordEntered = wordEntered.Length;

                        while (lengthOfWordEntered < 1)
                        {
                            Console.Write("You did not enter a word or phrase. Please enter it here: ");
                            wordEntered = Console.ReadLine().ToLower();
                            lengthOfWordEntered = wordEntered.Length;
                        }

                        if (ContainsSpace(wordEntered))
                        {
                            lowerCaseMyWords = wordEntered.ToLower();
                            arrayTest = wordEntered.Split(' ');

                            Console.Write("Your phrase translated to Pig Latin is: ");
                            foreach (string word in arrayTest)
                            {
                                Console.Write(PigLatin(word).ToLower() + " ");
                            }
                            Console.Write("\nWould you like to enter another word or phrase? (Y/N): ");
                            enterNewWord = Console.ReadLine();
                        }

                    } while (enterNewWord == "Y");
                }
            }
            else
            {
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

                        if (ContainsSpace(wordEntered))
                        {
                            string lowerCaseMyWords = wordEntered.ToLower();
                            string[] arrayTest = lowerCaseMyWords.Split(' ');

                            Console.Write("Your phrase translated to Pig Latin is: ");
                            foreach (string word in arrayTest)
                            {
                                Console.Write(PigLatin(word).ToLower() + " ");
                            }
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
}
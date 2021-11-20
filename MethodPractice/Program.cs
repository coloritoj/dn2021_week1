using System;

namespace MethodPractice
{
    class Program
    {
        static void ShowHelp()
        {
            Console.WriteLine("Welcome to the app.");
            Console.WriteLine("Please choose an option.");
            Console.WriteLine("When you are done you can click N");
        }

        static string GetFullName(string firstName, string lastName)
        {
            // return firstName + " " + lastName;

            return lastName + ", " + firstName;
        }

        static string GetFirstLetter(string word)
        {
            char first = word[0]; // Side note: the brackets you see here are called square bracket
            return first.ToString();
        }

        static string GetLastLetter(string word)
        {
            int index = word.Length - 1;
            char last = word[index];
            return last.ToString();
        }

        static string GetLastTwo(string word)
        {
            int index = word.Length - 2;
            string last2 = word.Substring(index, 2);
            return last2;
        }


        // Checks if string ends with A or B or C
        static bool EndsWithABC(string word)
        {
            string last = GetLastLetter(word).ToLower();
            if (last == "a" || last == "b" || last == "c") /// *** This is because this is a STATEMENT that evaluates to True or False. It is not a question. So the shortcut is to just to return whatever the statement evaluates to. The if/else return true/return false is kind of redundant.
            {
                return true;
            }
            else
            {
                return false;
            }

            // Note: If you really want to push yourself, understand why we could just do this instead:
            //
            // string last = GetLastLetter(word).ToLower();
            // return (last == "a" || last == "b" || last == "c");

            // Go look at *** for the answer
        }


        // Check if first letter is a vowel
        // Notice that characters use single quotes rather than double quotes
        // To check if the first letter is a consonant, just call this funciton but check for false
        // Pig Latin capstone is due Monday
        // The "INTRO" for Pig Latin is wrong where it says "Hello World would be elloyhay" (there is an extra y in the middle)
        static bool StartsWithVowel(string word)
        {
            char first = word[0];
            if (first == 'a' || first == 'e' || first == 'i' || first == 'o' || first == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
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

        // Checks if string ends with ING
        static bool EndsWithING(string word)
        {
            string last3 = word.Substring(word.Length - 3).ToLower();
            if (last3 == "ing")
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
            ShowHelp();

            string fullName = GetFullName("Sally", "Smith");
            Console.WriteLine(fullName);

            string anotherName = GetFullName("Fred", "Franklin");
            Console.WriteLine(anotherName);

            string firstLetter = GetFirstLetter("Hello");
            Console.WriteLine(firstLetter);

            string yetAnother = GetFullName("Jim", "Johnson");
            Console.WriteLine(yetAnother);

            string last = GetLastLetter("Hello");
            Console.WriteLine(last);

            Console.WriteLine("Substring practice");
            string myWord = "programming";
            Console.WriteLine(myWord.Substring(4, 5)); // prints rammi
            Console.WriteLine(myWord.Substring(0, 2)); // prints pr

            Console.WriteLine(GetLastTwo(myWord));

            Console.WriteLine(GetLastTwo("hello world!"));

            Console.WriteLine("Let's test the EndsWithABC!");
            Console.WriteLine(EndsWithABC("hello")); // expect False
            Console.WriteLine(EndsWithABC("pizza")); // expect True
            Console.WriteLine(EndsWithABC("PIZZA")); // expect True

            Console.WriteLine("Let's test the EndsWithING function!");
            Console.WriteLine(EndsWithING("walking")); // expect True
            Console.WriteLine(EndsWithING("walkinG")); // expect True
            Console.WriteLine(EndsWithING("walkING")); // expect True
            Console.WriteLine(EndsWithING("walkin")); // expect False
            Console.WriteLine(EndsWithING("walkiN")); // expect False

            // One way: Piece together a string
            string letters = "";
            for (int i = 0; i <= 10; i++)
            {
                letters += 'x';
            }
            Console.WriteLine(letters);

            // Another way: Locate the first vowel
            string test = "christmas";
            int firstVowel = -1;
            for (int i = 0; i < test.Length; i++)
            {
                if (IsVowel(test[i]))
                {
                    firstVowel = i;
                    break;
                }
            }
            Console.WriteLine(firstVowel);
            // If you want to grab the consonants: The first vowel is at location 3, and that's how many letters you grab starting at index 0.
            // If you want to grab everything starting with the first vowel until the end of the word, you will use that same number again, starting at 3.

            // Jeff said not to worry about the first extended exercise
            // Make the "pig latin" its own function... it will be a "PUBLIC STATIC STRING"; this will make the final extended exercise a lot easier. You'll call the function for each word. You will need to use arrays though. He didn't seem very concerned about doing the last extended exercise.
            
            // This is the basic structure of the pig latin function:
            /* public static string PigLatin(string word)
            {
                // Put your pig latin conversion in here

                string platin = word;
                return platin;
            } */


        }
    }
}

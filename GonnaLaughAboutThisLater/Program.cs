using System;

namespace GonnaLaughAboutThisLater
{
    class Program
    {
        static void Main(string[] args)
        {
            
            if (ContainsSpace(wordEntered))
            {
                int lengthOfPhrase = wordEntered.Length;
                int numberOfSpaces = 0;
                for (int i = 0; i < lengthOfPhrase; i++)
                {
                    if (IsSpace(wordEntered[i]))
                    {
                        numberOfSpaces++;
                    }
                }
                
                int numberOfWords = numberOfSpaces + 1;
                int[] indexOfSpaces = new int[wordEntered.Length];
                string[] wordsInPhrase = new string[numberOfWords];
                int indexIncrementOne = 0;

                // Need to loop to find the index of all spaces in the phrase
                // The index of the spaces will be used to create the substrings

                for (int i = 0; i < wordEntered.Length; i++)
                {
                    if (IsSpace(wordEntered[i]))
                    {
                        indexOfSpaces[indexIncrementOne] = i;
                        indexIncrementOne++;
                        i++;
                    }
                }

                int indexIncrementTwo = 0;
                int startOfWord = 0;


                for (int i = 0; i < numberOfWords; i++)
                {
                    wordsInPhrase[indexIncrementTwo] = wordEntered.Substring(startOfWord, (indexOfSpaces[indexIncrementTwo] - startOfWord));
                    startOfWord = indexOfSpaces[indexIncrementTwo]; // Becomes length of the index of the word placed in the array... for example: if the first word is "there", lengthOfWord is set to 5
                    indexIncrementTwo++;
                    i++;
                }

                Console.WriteLine($"There are {numberOfWords} words in your phrase");
                Console.WriteLine($"The index of the first space is {indexOfSpaces[0]}. The index of the second space is {indexOfSpaces[1]}. The index of the third space is {indexOfSpaces[2]}");
                Console.WriteLine($"\nThe word of index 0 in your wordsInPhrase array is... {wordsInPhrase[0]}. \nThe second word is... {wordsInPhrase[1]}. \nThe third word is... {wordsInPhrase[2]}. \nThe fourth word is... {wordsInPhrase[3]}.");
            }
           
        }
    }
}

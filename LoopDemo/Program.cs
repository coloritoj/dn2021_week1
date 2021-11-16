using System;

namespace LoopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before the loop");
            Console.WriteLine("Getting ready!");

            for (int i = 0; i <= 10; i++) // FOR loops run for as long as the middle condition is true (ex: i <= 10)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Let's count down starting with 10 and ending with 1 (inclusive for both)");

            for (int i = 10; i >= 1; i--) // When you declare a variable for a loop, it only lives within the loop and then it goes away when the loop ends (this is for C# - other languages might be different)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("All done!");

            // Ignore the first additional requirement
            // Ignore the first extra challenge
            // If I'm going to do an extra challenge, try doing the last one (it's an if/else that checks if it's less than 1 or greater than 100 and throws an error if they go outside the range)
          
        }
    }
}

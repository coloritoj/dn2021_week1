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

            Console.WriteLine("Let's count by 2's!");
            for (int i = 0; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Let's do a WHILE loop!");
            int j = 0;
            while (j <= 20) // Don't treat this as a question, treat is as a statement that evalutes to True or False
            {
                Console.WriteLine(j);
                if (j < 10)
                {
                    j++; // Increments by 1 while J is less than 10
                }
                else
                {
                    j += 2; // Increments by 2 when J is at 10 or above until it hits j <= 20
                }
            }
            Console.WriteLine("We're done with the while loop");
            Console.WriteLine($"The j variable is now {j}");

            Console.WriteLine("Let's do another while loop");
            j = 0; // j is already defined in the loop above, so you don't need to declare "int"; instead, just set j = 0
            while (j > 0)
            {
                Console.WriteLine(j); // This won't run because it's already False from the start; this is where a do-while loop can come in handy (below)
                j++;
            }

            Console.WriteLine("Let's do a do-while loop");
            j = 0;
            do
            {
                Console.WriteLine(j);
                j += 2;
            } while (j <= 20);

            Console.WriteLine("And one more do-while loop");
            j = 0;
            do
            {
                Console.WriteLine(j);
                j += 2;
            } while (j < 0); // This loop will run only one time because it added 2 to j; so the first j = 0 will print, but no iterations after that; do-while loops always run at least once



            Console.WriteLine("All done!");

            // Ignore the first additional requirement
            // Ignore the first extra challenge
            // If I'm going to do an extra challenge, try doing the last one (it's an if/else that checks if it's less than 1 or greater than 100 and throws an error if they go outside the range)
          
        }
    }
}

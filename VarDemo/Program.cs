using System;

namespace VarDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------------------------------------------------------------------- DAY 1 ----------------------------------------------------------------- //
            
            // Console.WriteLine("Hello \" World!");
            // Console.WriteLine("This is a second line of text");
            
            string message = "Hello world";
            Console.WriteLine(message);

            int AppleCount = 25;
            Console.WriteLine(AppleCount);
            Console.WriteLine(AppleCount + 1);
            Console.WriteLine(AppleCount);

            AppleCount = AppleCount + 10;
            Console.WriteLine(AppleCount);

            AppleCount = AppleCount * 2;
            Console.WriteLine(AppleCount);

            double x = 3.14;
            Console.WriteLine(x);

            // float y = 6.28F; We don't use floats often in this course

            double z = 20.0 / 3.0;
            Console.WriteLine(z);

            // We don't use floating point or double for money or financial programs
            //Instead we use decimal type
            decimal balance = 100.2512345m;
            Console.WriteLine(balance);

            bool atLunch = false;
            Console.WriteLine(atLunch);
            atLunch = true;
            Console.WriteLine(atLunch);

            // "null" - as in no shopping list at all, so we can't write on it
            string test = null;
            Console.WriteLine(test);

            // Practice noun dot verb
            Console.WriteLine(message.Length);
            Console.WriteLine(message.ToUpper()); //strings are immutable
            Console.WriteLine(message);
            message = "something else";
            Console.WriteLine(message);

            // More noun dot verb; this time with types themselves
            string nums = "37";
            int amount = int.Parse(nums);
            Console.WriteLine(amount * 2);

            Console.WriteLine("\nEnter an integer.");
            string entry = Console.ReadLine();
            int value = int.Parse(entry);
            Console.WriteLine(value * 20);

            // Don't do the final extra challenge (2 points: ask the user if they would like to go again, and if so, repeat) -- but you can do the first 3 extra challenges
            // Just name the project in a way that Antonio can understand; ask if you aren't sure what to do
            // Up to us 




            // ----------------------------------------------------------------------- DAY 2 ---------------------------------------------------------------------------------- //

            // A solution is simply a place to store multiple projects
            // Each project is a separate program that you can run
            // Ex: Software for a whole accounting company might be the solution; however each department might have a specific program written for them within the solution
            // Hierarchy of how it's saved on hard drive: SOLUTION >> FOLDER NAMED AFTER EACH PROJECT >> CODE FILES; this is called a tree
        }
    }
}

using System;

namespace ExpressionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            int z = x + y; // x + y is an "expression". What type do I get when I "evaluate" the expression?

            x = 100;
            y = 3;
            z = x / y; // 100 divided by 3 is 33.33333 which is NOT an integer. However, we are storing that number in an integer. It rounds it DOWN to an integer (even if it was like .66667).

            Console.WriteLine(z);

            // Let's explore booleans

            bool atLunch = false;
            Console.WriteLine(atLunch);

            // Let's do an expression that compares something
            // x has 100 in it, y has 3 in it
            // Instead of asking it as a question, "Is x greater than y?", which typically we respond with yes or no....
            //  let's make it a statement, "x is greater than y" and then state whether that statement is true or false.

            bool comp = x > y;
            Console.WriteLine("The statement x > y is either true or false: ");
            Console.WriteLine(comp);

            Console.WriteLine("Let's do some direct numbers: ");
            Console.WriteLine(100 < 3); // This will print False

            Console.WriteLine("Back to variables: ");
            Console.WriteLine(x < y); // This will print False because 100 is not less than 3

            Console.WriteLine("Store the result in a variable: ");
            comp = x < y; // Comp is a boolean; the statement is false, so it will store False in comp
            Console.WriteLine(comp);

            Console.WriteLine("Let's try a few boolean comparisons");
            Console.WriteLine(10 > 10); // false
            Console.WriteLine(10 > 9); // true
            Console.WriteLine(10 < 9); // false
            Console.WriteLine(10 == 10); // true
            Console.WriteLine(10 != 10); // false -- the "!=" is also known as "BANG"
            Console.WriteLine(10 / 2 == 5); // true
            /* Console.WriteLine(10 / 3 == 3); // WTF -- normally we don't do this to ourselves 
             *                                        -- just be careful with these kinds of things 
             *                                        -- this happened because 10/3 was rounded down to 3 */

            string first = "hello";
            string second = "hello";
            Console.WriteLine(first == second); // true -- In Java this would evaluate to false.
                                                // This is because some languages compare where things are stored in memory, not the actual values contained wihtin the variables.
            second = "Hello";
            Console.WriteLine(first == second); // true, this is because it compares character to character -- it doesn't care if it's lower or uppercase
        }
    }
}

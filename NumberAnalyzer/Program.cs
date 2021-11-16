using System;

namespace NumberAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ----- DIRECTIONS ----- 
             * 1 POINT: The application prompts the user to enter an integer between 1 and 100. It will then display the associated result based on the build below: --- COMPLETE
             * 1 POINT: Use if/else statements to take different actions depending on user input... --- COMPLETE
             * 1 POINT: If the integer entered is ODD and LESS THAN 60 print the number entered and "Odd and less than 60". --- COMPLETE
             * 1 POINT: If the integer entered is EVEN and IN THE INCLUSIVE RANGE OF 2 TO 24, print "Even and less than 25". --- COMPLETE
             * 1 POINT: If the integer entered is EVEN and IN THE INCLUSIVE RANGE OF 26 to 60, print "Even and between 26 and 60 inclusive". --- COMPLETE
             * 1 POINT: If the integer entered is EVEN and GREATER THAN 60, print the number entered and "Even and greater than 60". --- COMPLETE
             * 1 POINT: If the integer entered is ODD and GREATER THAN 60, print the number entered and "Odd and greater than 60". --- COMPLETE
             * 
             * ----- ADDITIONAL REQUIREMENTS -----
             * Don't worry about this section
             * 
             * ----- HINTS -----
             * Remember what "inclusive" and "exclusive" mean when referring to ranges of numbers
             * The range of numbers from 1 inclusive to 10 exclusive means the numbers 1, 2, 3, 4, 5, 6, 7, 8, and 9 will be printed (but not 10, it's excluded)
             * 
             * ----- EXTRA CHALLENGES
             * Skip the first challenge
             * 1 POINT: Ask user information (ex: name) at the beginning of the application and then use it to refer to the user throughout the application --- COMPLETE
             * 1 POINT: Add validation to guarantee that a user enters a positive integer between 1 and 100 --- COMPLETE
             */

            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            
            
            Console.WriteLine("Please enter an integer between 1 and 100: ");
            string integerEntered = Console.ReadLine();
            
            int temporaryInteger = int.Parse(integerEntered);


            do
            {
                if (temporaryInteger < 1 || temporaryInteger > 100)
                {
                    Console.WriteLine("You did not enter a valid integer. Please enter an integer between 1 and 100: ");
                    integerEntered = Console.ReadLine();
                    temporaryInteger = int.Parse(integerEntered);
                }
            } while (temporaryInteger < 1 || temporaryInteger > 100);


            int userInteger = temporaryInteger;


            if (userInteger % 2 != 0)
            {
                if (userInteger < 60)
                {
                    Console.WriteLine(userName + ", you entered " + userInteger + " which is an odd number and less than 60.");
                }
                else
                {
                    Console.WriteLine(userName + ", you entered " + userInteger + " which is an odd number and greater than 60.");
                }
            }
            else
            {
                if (userInteger >= 2 && userInteger <= 24)
                {
                    Console.WriteLine(userName + ", you entered " + userInteger + " which is even and less than 25.");
                }
                else if (userInteger >= 26 && userInteger <= 60)
                {
                    Console.WriteLine(userName + ", you entered " + userInteger + " which is even and between 26 and 60 inclusive.");
                }
                else
                {
                    Console.WriteLine(userName + ", you entered " + userInteger + " which is even and greater than 60.");
                }
            }
        }
    }
}

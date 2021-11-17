using System;

namespace ExponentsPowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ----- DIRECTIONS -----
             * 1 POINT: The application prompts the user to enter an integer. --- COMPLETE
             * 3 POINTS: The application displays a table of squares and cubes from 1 to the value entered. --- COMPLETE
             * 1 POINT: The application prompts the user to continue. --- COMPLETE
             * 
             * ---- BUILD SPECIFICATIONS -----
             * 1 POINT: Assume that the user will enter valid data.
             * 1 POINT: The application should continue only if the user agrees to.
             * 
             * ----- HINTS -----
             * Don't mess up the differences between squares and cubes!
             * Use \t to line up columns properly
             * 
             * ----- EXTRA CHALLENGES -----
             * 1 POINT: Provide validation by rejecting 0 or negative numbers as user input; keep prompting the user until they enter a valid number --- COMPLETE
             * 1 POINT: Research formatted strings and right-align the numbers in columns instead of left-aligning them --- DID NOT COMPLETE THIS
             * 1 POINT: Find out the maximum number whose cube will fit an int, and limit the user input to that number or less --- COMPLETE
             */


            // Asks the user for an integer. It then parses the STRING entered into an INT variable called temporaryInteger.
            Console.Write("Please enter an integer: ");
            string numberEntered = Console.ReadLine();
            int temporaryInteger = int.Parse(numberEntered);

            // A do-while loop runs. It first checks to see if the integer entered is less than or equal to 0.
            // If invalid (less than or equal to 0 OR greater than 1289) it tells the user they did not enter a valid integer and then asks them to re-enter until temporaryInteger is no longer less than or equal to 0 or greater than 1289.
            do
            {
                if (temporaryInteger <= 0 || temporaryInteger > 1289)
                {
                    Console.Write("You did not enter a valid integer. Please enter an integer greater than 0 but less than 1290: ");
                    numberEntered = Console.ReadLine();
                    temporaryInteger = int.Parse(numberEntered);
                }
            } while (temporaryInteger <= 0 || temporaryInteger > 1289);


            // Once the loop above is broken, it passes temporaryInteger into a new INT variable called userInteger.
            // userInteger becomes the variable we use going forward.
            int userInteger = temporaryInteger;

            // This userContinue STRING will be used later. We are just declaring it for now.
            string userContinue;

            // These two lines create the format of the table.

            Console.WriteLine("NUMBER\t\t\tSQUARED\t\t\tCUBED");
            Console.WriteLine("=======\t\t\t=======\t\t\t=======");


            // Another do-while loop is created and initializes i with 1.
            // The loop starts at 1. It squares and also cubes the result.
            // The loop then increments by 1 and squares/cubes the next number (in this case, 2).
            // The loop keeps incrementing by 1 until it reaches the userInteger variable.
            // The loop increments once more after it reaches the userInteger variable and then exits the loop.
            int i = 1;
            do
            {
                while (i <= userInteger)
                {
                    Console.WriteLine($"{i}\t\t\t{i * i}\t\t\t{i * i * i}");
                    i++;
                }

                // Now that the loop has exited, it asks the user if they would like to continue. Their answer is stored in the STRING variable we declared earlier called userContinue.
                // If the user enters anything BUT "Y", the main do-while loop terminates and the program ends.
                // If the user enters "Y" it passes that value into userContinue.
                Console.Write("Would you like to continue? (Y/N): ");
                userContinue = Console.ReadLine();

                // If the user wants to continue, the following if loop will run:
                if (userContinue == "Y")
                {
                    // User gets asked to enter an integer again.
                    // This number is passed into INT numberEntered from the Console.ReadLine() function
                    // This then gets passed to INT temporaryInteger
                    Console.Write("Please enter an integer: ");
                    numberEntered = Console.ReadLine();
                    temporaryInteger = int.Parse(numberEntered);

                    // Just like earlier in the program, if the value the user passes to INT temporaryInteger is less than or equal to 0 OR greater than 1289, the user receives an error message
                    // The error message will ask them to re-enter an integer that is greater than 0 less than 1290
                    // Once the user enters a valid integer, the while loop breaks
                    while (temporaryInteger <= 0 || temporaryInteger > 1289)
                    {
                        Console.Write("You did not enter a valid integer. Please enter an integer greater than 0 but less than 1290: ");
                        numberEntered = Console.ReadLine();
                        temporaryInteger = int.Parse(numberEntered);
                    }

                    // After the while loop breaks, the new integer they entered gets stored in INT userInteger
                    // Additionally, i gets reset back to 1 (this is because on the very first loop they entered earlier in the program, i ultimately got incremented to one more unit beyond the original number they entered)
                    userInteger = temporaryInteger;
                    i = 1;

                    // These 2 Console.WriteLines re-created the shape of the table
                    Console.WriteLine("NUMBER\t\t\tSQUARED\t\t\tCUBED");
                    Console.WriteLine("=======\t\t\t=======\t\t\t=======");

                    // This loops the user through their next table
                    while (i <= userInteger)
                    {
                        Console.WriteLine($"{i}\t\t\t{i * i}\t\t\t{i * i * i}");
                        i++;
                    }
                }
             // This will loop the user back to the start of the program
             // Since we reset i back to 1, it skips the first part of the main do-while loop
             // It then goes straight into asking if they wish to go through the program again
            } while (userContinue == "Y");

            // If the user ever answers with anything but "Y" when asked if they wish to repeat the program, this line will be read to the console and the program will end.
            Console.WriteLine("Goodbye!");
        }
    }
}

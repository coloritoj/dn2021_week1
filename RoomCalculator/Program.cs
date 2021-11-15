using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /* DIRECTIONS...
              * 1 POINT: The application prompts the users to enter values of length and width of the classroom. --- COMPLETE
              * 2 POINTS: The application displays the area and perimeter of that classroom. --- COMPLETE
              * 
              * BUILD SPECIFICATIONS...
              * 1 POINT: Assume that the rooms are perfect rectangles. --- COMPLETE
              * 1 POINT: Assume that the user will enter valid numeric data for length and width. --- COMPLETE
              * 1 POINT: The application should accept decimal (double) entries. --- COMPLETE
              * 
              * ADDITIONAL REQUIREMENTS...
              * 1 POINT: For answering the Lab Summary when submitting to the LMS
              * -2 POINTS: If there are any syntax errors or if the program does not run (for example, in a Main method)
              * 
              * HINTS...
              * Don't mess up the formulas for area or perimeter
              * The Snug is 24'6" x 20' 0". The Penthouse is 42'6" x 16'6".
              * 
              * EXTRA CHALLENGES...
              * 2 POINTS: The application classifies the room as small (up to 250 square feet), medium (more than 250 but less than 650 square feet), or large (650 square feet or more). --- COMPLETE
              * 1 POINT: Calculate the volume of the rooms. --- COMPLETE
              * 1 POINT: Calculate the surface area of the rooms. --- COMPLETE
              */



            Console.WriteLine("Please enter the length of the room (inches): ");
            string length = Console.ReadLine();
            double roomLength = double.Parse(length);

            Console.WriteLine("Please enter the width of the room (inches): ");
            string width = Console.ReadLine();
            double roomWidth = double.Parse(width);

            Console.WriteLine("Plese enter the height of the room (inches): ");
            string height = Console.ReadLine();
            double roomHeight = double.Parse(height);

            double roomArea = roomLength * roomWidth;
            double roomPerimeter = (roomLength * 2) + (roomWidth * 2);
            double roomVolume = roomLength * roomWidth * roomHeight;
            double roomSurfaceArea = (roomLength * 2) + (roomWidth * 2) + (roomHeight * 2);
            Console.WriteLine("The area of your clasroom is: " + roomArea + " square inches");
            Console.WriteLine("The perimeter of your classroom is: " + roomPerimeter + " inches");
            Console.WriteLine("The volume of your classroom is: " + roomVolume + " cubic inches");
            Console.WriteLine("The surface area of your room is: " + roomSurfaceArea + " square inches");

            if (roomArea <= 250)
            {
                Console.WriteLine("The area of your room is small.");
            }
            else if (roomArea > 250 && roomArea < 650)
            {
                Console.WriteLine("The area of your room is medium.");
            }
            else
            {
                Console.WriteLine("The area of your room is large.");
            }
        }
    }
}
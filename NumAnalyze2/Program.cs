using System;

namespace NumAnalyze2
{
    class Program
    {
        static bool IsOddUnder60(int num)
        {
            // Checking the expression for either true or ffalse
            if (num % 2 == 1 && num < 60)
            {
                // When the expression comes back true, return True
                return true;
            }
            else
            {
                // When the expression comes back false, return False
                return false;
            }
        }

        static bool IsOddOver60(int num)
        {
            // Really, we're just returning exactly what we got back from the expression
            // So let's just just return exactly what we got back
            return (num % 2 == 1 && num > 60); // Remember the expression contained inside is always going to evaluate to True or False. This is function is basically the same thing as the function above (except for the characteristics of the expression)
        }


        static void Main(string[] args)
        {
            int x = 61;
            if (IsOddUnder60(x) == true)
            {
                Console.WriteLine($"{x} is odd under 60.");
            }
            else if (IsOddOver60(x) == true)
            {
                Console.WriteLine($"{x} is odd over 60.");
            }
        }
    }
}

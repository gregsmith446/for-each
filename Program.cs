using System;

namespace ForEach
{
    class Program
    {
        static void Main()
        {
            // for each loop example

            // start by creating an array of ints as such
            int[] numbers = { 4, 5, 6, 7, 8, 9 };

            // loop through the array one number at a time
            foreach (int num in numbers)
            {
                Console.WriteLine("{0} ", num); // write each number to the console
            }


        }
    }
}

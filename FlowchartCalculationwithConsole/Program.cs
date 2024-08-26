using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowchartCalculationwithConsole // Defining a namespace to organize the code and prevent name conflicts.
{
    class Program // Defining the main class of the program.
    {
        static void Main(string[] args)  // The entry point of the program.
        {
            while (true) // Start an infinite loop to repeatedly ask for input until a valid interval is provided.
            {

                // Start of the program // Clear the console screen at the start of each iteration.
                Console.Clear();

                // Get min value from the user  // Prompt the user to enter the minimum value and read the input.
                Console.Write("Enter the minimum value (Min): ");
                int min = GetValidInteger(); // Call a method to ensure the input is a valid integer.

                // Get max value from the user 
                Console.Write("Enter the maximum value (Max): ");
                int max = GetValidInteger(); 

                // Get interval value from the user
                Console.Write("Enter the interval value: ");
                int interval = GetValidInteger();

                // Check if (max - min) % interval == 0. // Check if the interval evenly divides the range (max - min).
                if(interval == 0)
                {
                    Console.Write("Invalid Interval. press enter to start again!");
                    Console.ReadLine();
                    continue;

                }
                if ((max - min) % interval != 0)
                {
                    // If not, print invalid interval and repeat
                    Console.WriteLine("Invalid interval. Please try again.");
                    Console.WriteLine("Enter any key to continue...");
                    Console.ReadKey(); // Wait for the user to press a key.
                    
                    continue; // Go back to Get min, max, interval  // Restart the loop to get new input.
                }

                // Calculate n  // Calculate the number of intervals between min and max.
                int n = (max - min) / interval;
                Console.WriteLine("n is" + n);
                // Initialize i and sum
                int i = 1;
                int sum = 0;

                // Loop to calculate the sum
                while (i <= n) // Continue looping while i is less than or equal to n.
                {
                    sum += min; // Add the current min value to the sum.
                    min += interval; // Increment min by the interval value.
                    i++; // Increment the loop counter.
                }

                // Print the sum after exiting the loop. 
                Console.WriteLine($"The sum is: {sum}");

                // End the program or you say inform the use that the program will end.
                Console.WriteLine("Enter any key to exit...");
                Console.ReadKey(); // wait for the user to press any key 
                break; // Exit the loop and end the program // Exit the infinite loop, ending the program.
            }
        }

        // Method to get a valid integer from the user
        static int GetValidInteger()
        {
            int number; // Variable to store the valid integer.

            // Loop until a valid integer is entered.
            while (!int.TryParse(Console.ReadLine(), out number)) // TryParse attempts to convert the input to an integer.
            {
                Console.WriteLine("Invalid input. Please enter a valid integer."); // If conversion fails, prompt the user to enter a valid integer.
            }
            return number;
        }
    }
}

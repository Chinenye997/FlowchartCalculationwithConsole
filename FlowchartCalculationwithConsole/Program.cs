using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FlowchartCalculationWithConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // Start a loop to handle invalid inputs
            {
                Console.Clear();

                // Step 1: Get Min, Max, and Interval values
                Console.Write("Enter the minimum value (Min): ");
                int min = GetValidInteger();

                Console.Write("Enter the maximum value (Max): ");
                int max = GetValidInteger();

                Console.Write("Enter the interval value (Interval): ");
                int interval = GetValidInteger();

                // Step 2: First Condition: Check (Max - Min) % Interval == 0
                if ((max - min) % interval != 0)
                {
                    Console.WriteLine("Invalid interval. Please try again.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    continue; // Restart the loop
                }

                // Calculate N and initialize variables
                int n = (max - min) / interval;
                int i = 1; // Loop counter
                int sum = 0; // Initialize sum

                // Step 3: Loop for the Second Condition: i <= N
                while (i <= n)
                {
                    sum += min; // Add current Min value to sum
                    min += interval; // Update Min value
                    i++; // Increment loop counter
                }

                // Step 4: Print the sum and exit the program
                Console.WriteLine($"The sum is: {sum}");
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                break; // Exit the loop
            }
        }

        //Method to get a valid integer from the user
        static int GetValidInteger()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            return number;
        }
    }
}

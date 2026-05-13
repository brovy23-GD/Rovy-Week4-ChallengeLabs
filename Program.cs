// Week 4 Challenge Labs - C# Console Project
// Bobby Rovy | MSSA CAD Program
// Challenges: IfNumberContains3, DivisibleBy2Or3, Reverse String In-Place

using System; // Bring in basic .NET types like Console, int, string, etc.

namespace Rovy_Week4_ChallengeLabs // Namespace groups all the code for this project together
{
    class Program // The main class that holds all methods for this project
    {
        static void Main(string[] args) // Program entry point - this is the first method that runs
        {
            // This controls the main menu loop
            bool keepRunning = true; // Flag to keep the menu running until the user chooses to exit

            // Main menu loop will keep running until the user chooses Exit
            while (keepRunning) // Loop keeps going as long as keepRunning is true
            {
                Console.Clear(); // Clear the screen so the menu looks clean each time
                Console.WriteLine("   Rovy Week 4 Challenge Labs"); // Display the title of the program
                Console.WriteLine("--------------------------------------"); // Separator line
                Console.WriteLine("1. If Number Contains 3"); // Option 1
                Console.WriteLine("2. Divisible By 2 OR 3"); // Option 2
                Console.WriteLine("3. Reverse String In-Place"); // Option 3
                Console.WriteLine("0. Exit"); // Option to exit the program
                Console.Write("Select a challenge (0-3): "); // Ask the user to pick a challenge

                string choice = Console.ReadLine(); // Read the user's menu choice as a string

                Console.Clear(); // Clear screen before showing the selected challenge

                // Use a switch to run the correct challenge based on user input
                switch (choice)
                {
                    case "1":
                        RunContains3Challenge(); // Run Challenge 1
                        break;
                    case "2":
                        RunDivisibleBy2Or3Challenge(); // Run Challenge 2
                        break;
                    case "3":
                        RunReverseStringChallenge(); // Run Challenge 3
                        break;
                    case "0":
                        keepRunning = false; // Set flag to false so the loop ends
                        Console.WriteLine("Goodbye! Keep coding strong!"); // Exit message
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Press any key to try again."); // Handle bad input
                        Console.ReadKey(); // Wait for user before going back to menu
                        break;
                }
            }
        }

        // -----------------------------------------------
        // CHALLENGE 1 - If Number Contains 3
        // -----------------------------------------------

        // This method handles the user interaction for Challenge 1
        static void RunContains3Challenge()
        {
            Console.WriteLine("Challenge 1 - If Number Contains 3"); // Display the challenge title
            Console.WriteLine("-----------------------------------"); // Separator for readability

            Console.Write("Enter a positive integer: "); // Prompt the user to enter a number
            string input = Console.ReadLine(); // Read the user input as a string

            // Parse as long so the user can enter very large numbers
            long numberLong = long.Parse(input); // Convert the string input to a long (supports big numbers)

            // Check if the number is too big to fit in an int before casting
            if (numberLong < int.MinValue || numberLong > int.MaxValue)
            {
                // If it is out of int range, tell the user and stop here
                Console.WriteLine("Number is too large for int range. Please enter a smaller number.");
                Console.WriteLine("Press any key to return to the main menu.");
                Console.ReadKey(); // Wait for key press
                return; // Exit this method early
            }

            int number = (int)numberLong; // Safely cast the long to int now that we know it fits

            bool result = IfNumberContains3(number); // Call the logic method and store the true/false result

            Console.WriteLine();
            Console.WriteLine($"IfNumberContains3({number}) -> {result}"); // Display the result
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey(); // Wait before going back to the menu
        }

        // Core logic for Challenge 1 - checks if any digit in the number is 3
        static bool IfNumberContains3(int number) // Takes an int and returns true or false
        {
            int n = number; // Copy the number into a local variable so we don't change the original

            if (n == 0) // If the number is 0, it has no digits to check
            {
                return false; // 0 does not contain the digit 3 so return false
            }

            while (n > 0) // Loop through each digit until there are none left
            {
                int digit = n % 10; // Get the last digit using the modulo (remainder) operator
                if (digit == 3) // Check if that last digit is 3
                {
                    return true; // Found a 3 - return true immediately
                }
                n = n / 10; // Remove the last digit by dividing by 10 (integer division drops the remainder)
            }

            return false; // We checked every digit and found no 3, so return false
        }

        // -----------------------------------------------
        // CHALLENGE 2 - Divisible By 2 OR 3
        // -----------------------------------------------

        // This method handles the user interaction for Challenge 2
        static void RunDivisibleBy2Or3Challenge()
        {
            Console.WriteLine("Challenge 2 - Divisible By 2 OR 3"); // Display the challenge title
            Console.WriteLine("----------------------------------"); // Separator

            // Ask for the first integer
            Console.Write("Enter the first integer: "); // Prompt for first number
            int firstNumber = int.Parse(Console.ReadLine()); // Read and parse as int

            // Ask for the second integer
            Console.Write("Enter the second integer: "); // Prompt for second number
            int secondNumber = int.Parse(Console.ReadLine()); // Read and parse as int

            // Call the logic method for each number separately
            bool firstResult = DivisibleBy2Or3(firstNumber); // Check first number
            bool secondResult = DivisibleBy2Or3(secondNumber); // Check second number

            Console.WriteLine();
            Console.WriteLine($"DivisibleBy2Or3({firstNumber}) -> {firstResult}"); // Show result for first number
            Console.WriteLine($"DivisibleBy2Or3({secondNumber}) -> {secondResult}"); // Show result for second number
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey(); // Wait before going back to the menu
        }

        // Core logic for Challenge 2 - returns true if divisible by 2 OR 3 but NOT both
        static bool DivisibleBy2Or3(int number) // Takes an int and returns true or false
        {
            bool divisibleBy2 = (number % 2 == 0); // true if number divides evenly by 2 (no remainder)
            bool divisibleBy3 = (number % 3 == 0); // true if number divides evenly by 3 (no remainder)

            // XOR (^) means: true only when EXACTLY ONE of the two conditions is true
            // divisible by 2 only = true, divisible by 3 only = true, both = false, neither = false
            return divisibleBy2 ^ divisibleBy3;
        }

        // -----------------------------------------------
        // CHALLENGE 3 - Reverse String In-Place
        // -----------------------------------------------

        // This method handles the user interaction for Challenge 3
        static void RunReverseStringChallenge()
        {
            Console.WriteLine("Challenge 3 - Reverse String In-Place"); // Display the challenge title
            Console.WriteLine("--------------------------------------"); // Separator

            // Ask the user for a string
            Console.Write("Enter a string to reverse: "); // Prompt the user to enter a string to reverse
            string input = Console.ReadLine(); // Read the user input as a string

            // Convert the string to a char array so we can modify it in-place
            char[] s = input.ToCharArray(); // Turn the string into an array of characters (e.g. "hi" -> ['h','i'])

            Console.WriteLine();
            Console.WriteLine("Original char array:"); // Label before showing the original char array
            PrintCharArray(s); // Call helper method to display the original char array to the user

            // Call the in-place reverse method
            ReverseCharArrayInPlace(s); // Reverse the characters directly in the same array (no new array created)

            Console.WriteLine();
            Console.WriteLine("Reversed char array:"); // Label before showing the reversed char array
            PrintCharArray(s); // Call helper method to display the reversed char array to the user

            // Also show the reversed string version for easy reading
            Console.WriteLine();
            Console.WriteLine("Reversed as string: " + new string(s)); // Convert char array back to string and print it
            Console.WriteLine("Press any key to return to main menu"); // Tell the user how to go back
            Console.ReadKey(); // Wait for key press before returning to the menu
        }

        // Reverses the characters in the array s in-place (modifies the original array, no new array needed)
        static void ReverseCharArrayInPlace(char[] s) // Takes a char array and reverses it by swapping from both ends
        {
            int left = 0; // Left pointer starts at the very beginning of the array (index 0)
            int right = s.Length - 1; // Right pointer starts at the very end of the array (last index)

            while (left < right) // Keep looping until the two pointers meet or cross in the middle
            {
                // Swap the characters at the left and right positions
                char temp = s[left]; // Save the left character in a temporary variable so we don't lose it
                s[left] = s[right]; // Copy the right character into the left position
                s[right] = temp; // Put the saved left character into the right position

                // Move both pointers toward the center
                left++; // Move left pointer one step to the right
                right--; // Move right pointer one step to the left
                // When left meets right, every character has been swapped and the array is fully reversed
            }
        }

        // Helper method to print a char array in the format ['h','e','l','l','o']
        static void PrintCharArray(char[] s) // Takes a char array and prints it in a readable format
        {
            Console.Write("["); // Print the opening bracket before listing characters

            for (var i = 0; i < s.Length; i++) // Loop through each character in the array
            {
                Console.Write("'" + s[i] + "'"); // Print the current character wrapped in single quotes

                if (i < s.Length - 1) // Check if this is NOT the last character
                {
                    Console.Write(", "); // Print a comma and space to separate characters
                }
            }

            Console.WriteLine("]"); // Print the closing bracket and move to the next line
        }
    }
}

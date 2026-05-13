// Week 4 Challenge Labs - C# Console Project
// Bobby Rovy | MSSA CAD Program
// Challenges: IfNumberContains3, DivisibleBy2Or3, Reverse String In-Place

using System;

namespace Rovy_Week4_ChallengeLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            // This controls the main menu loop
            bool keepRunning = true;

            // Main menu loop will keep running until the user chooses Exit
            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("   Rovy Week 4 Challenge Labs");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1. If Number Contains 3");
                Console.WriteLine("2. Divisible By 2 OR 3");
                Console.WriteLine("3. Reverse A String");
                Console.WriteLine("4. Exit");
                Console.WriteLine("---------------------------------------");
                Console.Write("Enter your choice (1-4): ");

                // Read the user choice as text
                string choice = Console.ReadLine();

                Console.Clear();// Clear the console before running the chosen challenge for better readability

                // Use switch to call the correct challenge
                switch (choice)
                {
                    case "1":
                        RunContains3Challenge();// Challenge 1: If number contains digit 3
                        break;

                    case "2":
                        RunDivisibleBy2Or3Challenge();// Challenge 2: Divisible by 2 or 3
                        break;

                    case "3":
                        RunReverseStringChallenge();// Challenge 3: Reverse string in-place
                        break;

                    case "4":
                        keepRunning = false;
                        Console.WriteLine("Exiting... Goodbye!");// Challenge 4: Exit
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, 3, or 4.");// Handle invalid input
                        break;
                }

                // If the user did not choose Exit there will be a pause before returning to the menu
                if (keepRunning)
                {
                    Console.WriteLine();// Add a blank line for spacing
                    Console.WriteLine("Press Enter to return to the menu...");// Prompt to return to menu

                }
            }
        }


        // Challenge 1: If number contains digit 3

        static void RunContains3Challenge() // This method handles the user interaction for Challenge 1
        {
            Console.WriteLine("Challenge 1 - If Number Contains 3"); // Display the challenge title
            Console.WriteLine("--------------------------------");   // Display a separator for better readability

            Console.Write("Enter a positive integer: ");              // Prompt the user
            long number = long.Parse(Console.ReadLine());             // Read input as long

            bool result = IfNumberContains3(number);                  // Make sure this overload takes a long

            Console.WriteLine();
            Console.WriteLine($"If Number Contains 3({number}) -> {result}"); // Display the result
        }

        // This method checks whether the given positive integer contains digit 3.

        static bool IfNumberContains3(long number) 
        {
            long n = number; //

            if (n == 0)
            {
                return false;// 
            }

            while (n > 0)// Loop through each digit of the number
            {
                long digit = n % 10;// Get the last digit of the number
                if (digit == 3)
                {
                    return true;// If the digit is 3, return true immediately
                }
                n = n / 10;// Remove the last digit and continue checking the next one
            }

            return false;// If we finish the loop without finding a 3, return false
        }

        // Challenge 2: Divisible by 2 or 3

        // Challenge 2: Divisible by 2 or 3 (two integers version)
        static void RunDivisibleBy2Or3Challenge() // This method handles the user interaction for Challenge 2
        {
            Console.WriteLine("Challenge 2 - Divisible By 2 OR 3");// Display the challenge title
            Console.WriteLine("----------------------------------");// Display a separator for better readability

            // Ask for the first integer
            Console.Write("Enter the first integer: ");// Prompt the user to enter the first integer
            int firstNumber = int.Parse(Console.ReadLine());// Read the first integer from the user input

            // Ask for the second integer
            Console.Write("Enter the second integer: ");
            int secondNumber = int.Parse(Console.ReadLine());// Read the second integer from the user input

            // Call the logic method for each number
            bool firstResult = DivisibleBy2Or3(firstNumber);// Check if the first number is divisible by 2 or 3 (but not both)
            bool secondResult = DivisibleBy2Or3(secondNumber);// Check if the second number is divisible by 2 or 3 (but not both)

            Console.WriteLine();
            Console.WriteLine($"Divisible By 2 OR 3({firstNumber}) -> {firstResult}");// Display the result for the first number
            Console.WriteLine($"Divisible By 2 OR 3({secondNumber}) -> {secondResult}");// Display the result for the second number

            Console.WriteLine("Press any key to return to the main menu.");// Prompt the user to press any key before returning to the menu
            Console.ReadKey();
        }
     // Returns true if the number is divisible by 2 or 3, but NOT both
static bool DivisibleBy2Or3(int number)
        {
            bool divisibleBy2 = (number % 2 == 0); // true if divisible by 2
            bool divisibleBy3 = (number % 3 == 0); // true if divisible by 3

            // XOR: true when exactly one of them is true
            return divisibleBy2 ^ divisibleBy3;
        }

        // Challenge 3: Reverse string in-place

        static void RunReverseStringChallenge()// This method handles the user interaction for Challenge 3
        {
            Console.WriteLine("Challenge 3 - Reverse A String");// Display the challenge title
            Console.WriteLine("---------------------------------------------");// Display a separator for better readability

            // Week 4 Challenge Labs - C# Console Project
            // This section runs the "Reverse String In-Place" challenge inside your program.

            // Ask user for a string.
            Console.Write("Enter a string to reverse: ");        // Show a message so the user knows what to type
            string input = Console.ReadLine();                   // Read everything the user types until they press Enter

            // Convert the string to a char array so we can modify it in-place.
            char[] s = input.ToCharArray();                      // Turn the string into an array of characters (e.g. "hi" -> ['h','i'])

            Console.WriteLine();                                 // Print an empty line for spacing
            Console.WriteLine("Original char array:");           // Label to show we are about to print the original characters
            PrintCharArray(s);                                   // Call a helper method to print the char array nicely

            // Call the in-place reverse method.
            ReverseCharArrayInPlace(s);                          // Reverse the order of the characters directly in the same array

            Console.WriteLine();                                 // Another empty line for spacing
            Console.WriteLine("Reversed char array:");           // Label to show the reversed characters
            PrintCharArray(s);                                   // Print the array again, now it should be reversed

            // Also show the reversed string version (for easy reading).
            Console.WriteLine();                                 // Empty line for spacing
            Console.WriteLine("Reversed as string: " + new string(s));
            // Create a new string from the reversed char array and print it so it looks like normal text

            Console.WriteLine("Press any key to return to main menu");
            // Tell the user what to do next

            Console.ReadKey();                                   // Wait for the user to press any key before continuing / leaving the screen


            // Reverses the characters in the array s in-place (no new array)
            // "In-place" means we change the original array instead of creating a new one.
            static void ReverseCharArrayInPlace(char[] s)        // Method that takes a char array and reverses it
            {
                int left = 0;                                    // Start pointer at the beginning of the array (index 0)
                int right = s.Length - 1;                        // Start pointer at the end of the array (last index)

                while (left < right)                             // Keep running while left index is before right index
                {
                    // Swap
                    char temp = s[left];                         // Save the character at the left index in a temporary variable
                    s[left] = s[right];                          // Copy the character from the right index into the left position
                    s[right] = temp;                             // Put the saved left character into the right position

                    // Move indices toward the center
                    left++;                                      // Move the left pointer one step to the right
                    right--;                                     // Move the right pointer one step to the left
                                                                 // Eventually left will meet or cross right, and the array will be fully reversed
                }
            }


            // Helper method to print a char array in the format ['h','e','l','l','o']
            static void PrintCharArray(char[] s)                 // Method that prints all characters in the array in a nice format
            {
                Console.Write("[");                              // Print opening bracket before listing characters

                // Loop through each character in the array and print it with quotes and commas
                for (var i = 0; i < s.Length; i++)               // Start at index 0, stop when i reaches the length of the array
                {
                    Console.Write("'" + s[i] + "'");             // Print the current character with single quotes around it

                    if (i < s.Length - 1)                        // If this is NOT the last character in the array
                    {
                        Console.Write(", ");                     // Print a comma and space after it to separate values
                    }
                }

                Console.WriteLine("]");                          // Print the closing bracket and move to the next line
            }
        }
    }
}

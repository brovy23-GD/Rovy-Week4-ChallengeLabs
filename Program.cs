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
                Console.WriteLine("1. IfNumberContains3");
                Console.WriteLine("2. DivisibleBy 2 OR 3");
                Console.WriteLine("3. Reverse String (in-place char[])");
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
                        Console.WriteLine("Exiting. Goodbye!");// Challenge 4: Exit
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
                    Console.ReadLine();// Wait for user to press Enter before clearing the console and showing the menu again
                }
            }
        }

       
        // Challenge 1: If number contains digit 3
      
        static void RunContains3Challenge()// This method handles the user interaction for Challenge 1
        {
            Console.WriteLine("Challenge 1 - IfNumberContains3");// Display the challenge title
            Console.WriteLine("--------------------------------");// Display a separator for better readability

            Console.Write("Enter a positive integer: ");// Prompt the user to enter a positive integer
            int number = int.Parse(Console.ReadLine());// Read the user input and convert it to an integer

            bool result = IfNumberContains3(number);// Call the method to check if the number contains digit 3 and store the result

            Console.WriteLine();
            Console.WriteLine($"IfNumberContains3({number}) -> {result}");// Display the result of the check to the user
        }

        // This method checks whether the given positive integer contains digit 3.
        
        static bool IfNumberContains3(int number) // Returns true if the number contains the digit 3, false otherwise
        {
            // Work with a copy so we don't change the original variable accidentally
            int n = number;

            // Special case; if number is 0, it clearly does not contain 3
            if (n == 0)
            {
                return false;
            }

            // Loop until we have no digits left
            while (n > 0)
            {
                // Get the last digit using modulo 10
                int digit = n % 10;

                // If the last digit is 3; return true immediately
                if (digit == 3)
                {
                    return true;
                }

                // Drop the last digit by dividing by 10 (integer division)
                n = n / 10;
            }

            // If we finish the loop without finding a 3; return false
            return false;
        }

     
        // Challenge 2: Divisible by 2 or 3
       
        static void RunDivisibleBy 2Or3Challenge()// This method handles the user interaction for Challenge 2
        {
            Console.WriteLine("Challenge 2 - DivisibleBy 2 OR 3");// Display the challenge title
            Console.WriteLine("--------------------------------");// Display a separator for better readability

            Console.Write("Enter first integer (a): ");// Prompt the user to enter the first integer
            int a = int.Parse(Console.ReadLine());// Read the user input and convert it to an integer

            Console.Write("Enter second integer (b): ");// Prompt the user to enter the second integer
            int b = int.Parse(Console.ReadLine());//    Prompt the user to enter the second integer and convert it to an integer

            int result = DivisibleBy2Or3(a, b);// Call the method to compute the result based on the divisibility rules and store it

            Console.WriteLine();// Add a blank line for better readability
            Console.WriteLine($"DivisibleBy2Or3({a}, {b}) -> {result}");// Display the result of the computation to the user
        }

        // Given two integers; returns their multiplication if both are divisible by 2 or 3;
        // otherwise returns their sum
        static int DivisibleBy2Or3(int a, int b)
        {
            // aOk is true if a is divisible by 2 OR divisible by 3
            bool aOk = (a % 2 == 0) || (a % 3 == 0);

            // bOk is true if b is divisible by 2 OR divisible by 3
            bool bOk = (b % 2 == 0) || (b % 3 == 0);

            // If both a and b satisfy the condition; return multiplication
            if (aOk && bOk)
            {
                return a * b;// If both a and b are divisible by 2 or 3, return their product
            }
            else
            {
                // Otherwise, return sum.
                return a + b;
            }
        }

        // Challenge 3: Reverse string in-place
      
        static void RunReverseStringChallenge()// This method handles the user interaction for Challenge 3
        {
            Console.WriteLine("Challenge 3 - Reverse String (in-place char[])");// Display the challenge title
            Console.WriteLine("---------------------------------------------");// Display a separator for better readability

            // Ask user for a string.
            Console.Write("Enter a string to reverse: ");// Prompt the user to enter a string to reverse
            string input = Console.ReadLine();// Read the user input as a string

            // Convert the string to a char array so we can modify it in-place.
            char[] s = input.ToCharArray();

            Console.WriteLine();
            Console.WriteLine("Original char array:");//    
            PrintCharArray(s);// Display the original char array to the user

            // Call the in-place reverse method.
            ReverseCharArrayInPlace(s);

            Console.WriteLine();
            Console.WriteLine("Reversed char array:");// Display the reversed char array to the user
            PrintCharArray(s);// Display the reversed char array to the user

            // Also show the reversed string version (for easy reading).
            Console.WriteLine();
            Console.WriteLine("Reversed as string: " + new string(s));// Display the reversed char array as a string for easier reading
        }

        // Reverses the characters in the array s in-place (no new array)
        static void ReverseCharArrayInPlace(char[] s)
        {
            // left starts at the beginning, right starts at the end
            int left = 0;
            int right = s.Length - 1;

            // Move inward until the two indices meet or cross
            while (left < right)
            {
                
                char temp = s[left];// Store the character at the left index in a temporary variable 
                s[left] = s[right];// Swap the characters at left and right indices
                s[right] = temp;//

                // Move indices toward the center
            }
        }

        // Helper method to print a char array in the format ['h','e','l','l','o']
        static void PrintCharArray(char[] s)
        {
            Console.Write("[");
            for (int i = 0; i < s.Length; i++)// Loop through each character in the array and print it with quotes and commas
            {
                Console.Write("'" + s[i] + "'");// Print the current character with single quotes around it
                if (i < s.Length - 1)
                {
                    Console.Write(", ");// Print a comma and space after each character except the last one
                }
            }
            Console.WriteLine("]");// Print the closing bracket and move to a new line
        }
    }
}

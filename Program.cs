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
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("===== Week 4 Challenge Labs =====");
                Console.WriteLine("1. Does Number Contain Digit 3?");
                Console.WriteLine("2. Divisible By 2 Or 3 (Multiply vs Sum)");
                Console.WriteLine("3. Reverse String In-Place");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RunIfNumberContains3();
                        break;
                    case "2":
                        RunDivisibleBy2Or3();
                        break;
                    case "3":
                        RunReverseString();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // Challenge 1: IfNumberContains3
        // Checks if a given number contains the digit 3 using % and /
        static void RunIfNumberContains3()
        {
            Console.Clear();
            Console.WriteLine("--- Does Number Contain Digit 3? ---");
            Console.Write("Enter a positive integer: ");

            if (!int.TryParse(Console.ReadLine(), out int number) || number < 0)
            {
                Console.WriteLine("Invalid input. Press any key to return.");
                Console.ReadKey();
                return;
            }

            bool contains3 = IfNumberContains3(number);
            Console.WriteLine($"{number} {(contains3 ? "CONTAINS" : "does NOT contain")} the digit 3.");
            Console.WriteLine("\nPress any key to return to menu.");
            Console.ReadKey();
        }

        // Returns true if the number contains digit 3
        static bool IfNumberContains3(int n)
        {
            if (n == 0) return false;
            n = Math.Abs(n);
            while (n > 0)
            {
                if (n % 10 == 3)  // Check last digit
                    return true;
                n /= 10;          // Remove last digit
            }
            return false;
        }

        // Challenge 2: DivisibleBy2Or3
        // Multiplies if divisible by both 2 and 3, sums if only one, else prints both
        static void RunDivisibleBy2Or3()
        {
            Console.Clear();
            Console.WriteLine("--- Divisible By 2 Or 3 ---");
            Console.Write("Enter first number: ");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Invalid input. Press any key to return.");
                Console.ReadKey();
                return;
            }
            Console.Write("Enter second number: ");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Invalid input. Press any key to return.");
                Console.ReadKey();
                return;
            }

            bool divBy2 = (a % 2 == 0 || b % 2 == 0);
            bool divBy3 = (a % 3 == 0 || b % 3 == 0);

            if (divBy2 && divBy3)
                Console.WriteLine($"Both conditions met! Product: {a * b}");
            else if (divBy2 || divBy3)
                Console.WriteLine($"One condition met. Sum: {a + b}");
            else
                Console.WriteLine($"Neither condition met. {a} and {b}");

            Console.WriteLine("\nPress any key to return to menu.");
            Console.ReadKey();
        }

        // Challenge 3: Reverse String In-Place
        // Reverses a char array using two-pointer swap - O(n) time, O(1) space
        static void RunReverseString()
        {
            Console.Clear();
            Console.WriteLine("--- Reverse String In-Place ---");
            Console.Write("Enter a string to reverse: ");
            string input = Console.ReadLine();

            char[] chars = input.ToCharArray();
            ReverseInPlace(chars);
            string reversed = new string(chars);

            Console.WriteLine($"Original : {input}");
            Console.WriteLine($"Reversed : {reversed}");
            Console.WriteLine("\nPress any key to return to menu.");
            Console.ReadKey();
        }

        // Two-pointer in-place reversal - no extra array needed
        static void ReverseInPlace(char[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                char temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
        }
    }
}

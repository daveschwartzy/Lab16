using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                //initialize array of prime numbers 1-45
                int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97,
                101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197,};
                bool success = true;
                while (success)
                {
                   //inform user of program's purpose
                    Console.WriteLine("This program will locate prime numbers from 1-45. (ex: Prime 5 is 11)\n");
                    {
                        //call method to verify that user input is a number between 1-45, not a word, char, or anything else
                        LocatePrimes(primes);
                        success = false;
                    }
                    //call method to repeat program
                    repeat = DoAgain($"\nWould you like to find another prime number? (Y or N): \n");
                }
            }
            //if user said they do not want to run the program again, this message will display as they are "leaving"
            Console.WriteLine("Goodbye!");

        }
        //method to validate user input as a valid number - will keep asking until it gets a valid response
        private static void LocatePrimes(int[] primes)
        {
            Console.Write("Which prime number are you looking for? (Enter a number 1-45) \n");
            string input = Console.ReadLine();
            int.TryParse(input, out int number);
            if (number < 1 || number > (primes.Length))
            {
                Console.WriteLine("I'm sorry, that is not a valid response.");
                LocatePrimes(primes);
            }
            else
            {
                Console.WriteLine($"\nThe number {number} prime is {primes[number - 1]}.");
            }

        }
        //method to repeat program - will only accept responses of y or no, otherwise will keep asking
        private static bool DoAgain(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine().ToLower();
            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                Console.Write("Invalid input. ");
                return DoAgain(prompt);
            }
        }
    }
}

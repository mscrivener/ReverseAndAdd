using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAndAdd
{
    class Program
    {
        private const int startCounterValue = 1;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to \"Reverse and Add\"");

            try
            {
                //declare variable
                ulong input = 0;

                input = GetUserInput();

                //TODO: only keep one if this was for real, but it's a test, so I'm just providing topics for conversation
                //Recursive implementation
                //ProcessNumberRecursive(input, startCounterValue);

                //Loop implementation
                ProcessNumberLoop(input, startCounterValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //wait and finish if an exeption is shown
            Console.WriteLine("Thanks for trying \"Reverse and Add\". Hit enter to finish:");
            Console.ReadLine();
        }

        /// <summary>
        /// reads the user proveded input
        /// makes an assumption that a whole, non-negative number is entered
        /// </summary>
        /// <returns>ulong representation of user input</returns>
        public static ulong GetUserInput()
        {
            Console.WriteLine("Please enter a positive integer to start a sequence:");

            //declare variable
            ulong input = 0;

            //get the input integer
            ulong.TryParse(Console.ReadLine(), out input);
            //TODO: handle bad input

            return input;
        }

        #region "Processing numbers"

        /// <summary>
        /// Recursive implementation of the rules
        /// </summary>
        /// <param name="input"></param>
        /// <param name="counter"></param>
        public static void ProcessNumberRecursive(ulong input, int counter)
        {
            ulong output = 0;
            ulong sum = 0;

            //reverse the number
            output = Logik.NumberHandler.ReverseInput(input);

            //get the sum
            sum = Logik.NumberHandler.AddNumbers(input, output);

            
            //if not yet a palindrome, recursively invoke with counter add 
            if (!Logik.NumberHandler.IsPalindrome(input, output) || counter == 1)
            {
                WriteResultToConsole(counter, input, output, sum);

                //count up
                counter++;

                ProcessNumberRecursive(sum, counter);
            }
            else //get a new user input
                ProcessNumberRecursive(GetUserInput(), startCounterValue); 
        }

        /// <summary>
        /// implementation usign do/while
        /// </summary>
        /// <param name="input"></param>
        /// <param name="counter"></param>
        public static void ProcessNumberLoop(ulong input, int counter)
        {
            ulong reversedInput = 0;
            ulong sum = 0;

            //reverse the input
            reversedInput = Logik.NumberHandler.ReverseInput(input);

            //the loop should end with a reverse to check if sum was palindrome
            //keep looping until it is
            do
            {
                //sum the input and reverse
                sum = Logik.NumberHandler.AddNumbers(input, reversedInput);

                //
                WriteResultToConsole(counter, input, reversedInput, sum);
                //
                counter++;

                //for the next round, the input will be the sum of this round
                input = sum;
                //reverse the input (sum from prev. round) to check for palindrome
                reversedInput = Logik.NumberHandler.ReverseInput(input);

            } while (!Logik.NumberHandler.IsPalindrome(input, reversedInput));

            //run a new round with user input
            ProcessNumberLoop(GetUserInput(), startCounterValue);
        }

#endregion

        /// <summary>
        /// for consistent formatting, use this to write a result to the console
        /// </summary>
        /// <param name="counter"></param>
        /// <param name="firstnumber"></param>
        /// <param name="secondnumber"></param>
        /// <param name="sum"></param>
        public static void WriteResultToConsole(int counter, ulong firstnumber, ulong secondnumber, ulong sum)
        {
            //write output to console
            Console.WriteLine(counter.ToString() + ". " + firstnumber.ToString() + " + " + secondnumber.ToString() + " = " + sum.ToString());
        }
    }
}

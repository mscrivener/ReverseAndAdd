using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAndAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to \"Reverse and Add\"");

            try
            {
                GetInput();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            //wait
            Console.ReadLine();
        }

        public static void GetInput()
        {
            Console.WriteLine("Please enter a positive integer to start a sequence:");

            //declare variables
            ulong input = 0;
            
            //get the input integer
            ulong.TryParse(Console.ReadLine(), out input);
            //TODO: handle bad input

            //Recursive implementation
            //ProcessNumberRecursive(input, 1);

            //Loop implementation
            ProcessNumberLoop(input, 1);
        }
        
        public static void ProcessNumberRecursive(ulong input, int counter)
        {
            ulong output = 0;
            ulong sum = 0;

            //reverse the number
            output = Logik.NumberHandler.ReverseInput(input);

            //get the sum
            sum = Logik.NumberHandler.AddNumbers(input, output);

            
            //if not yet a palindrome, recursively invoke with counter add 
            //also, definitely write the first iteration
            //TODO: clean this up!
            if (!Logik.NumberHandler.IsPalindrome(input, output) || counter == 1)
            {
                WriteResultToConsole(counter, input, output, sum);

                //count up
                counter++;

                ProcessNumberRecursive(sum, counter);
            }
            else //get a new user input
                GetInput();
        }

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
            GetInput();
        }

        public static void WriteResultToConsole(int counter, ulong firstnumber, ulong secondnumber, ulong sum)
        {
            //write output to console
            Console.WriteLine(counter.ToString() + ". " + firstnumber.ToString() + " + " + secondnumber.ToString() + " = " + sum.ToString());
        }
    }
}

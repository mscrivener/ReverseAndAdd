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
            Console.WriteLine("Please enter a positive integer to start:");


            GetFreshInput();                                  
            
            //wait
            Console.ReadLine();
        }

        public static void GetFreshInput()
        {
            //declare variables
            long input = 0;


            //get the input integer
            long.TryParse(Console.ReadLine(), out input);
            //TODO: handle bad input

            //
            ProcessNumber(input, 1);
        }
        
        public static void ProcessNumber(long input, int counter)
        {
            long output = 0;
            long sum = 0;

            //reverse the number
            output = Logik.NumberHandler.ReverseInput(input);

            //get the sum
            sum = Logik.NumberHandler.AddNumbers(input, output);

            //if not yet a palindrome, recursively invoke with counter add 
            //TODO: one digit input should not end this!
            if (input != output)
            {
                //write output to console
                Console.WriteLine(counter.ToString() + ". " + input.ToString() + " + " + output.ToString() + " = " + sum.ToString());

                //count up
                counter++;

                ProcessNumber(sum, counter);
            }
            else
                GetFreshInput();
        }
    }
}

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

            //declare variables
            int input = 0;
                     

            //get the input integer
            int.TryParse(Console.ReadLine(), out input);
            //TODO: handle bad input

            //
            ProcessNumber(input, 1);
                                  
            
            //wait
            Console.ReadLine();
        }

        
        public static void ProcessNumber(int input, int counter)
        {
            int output = 0;
            int sum = 0;

            //reverse the number
            output = Logik.NumberHandler.ReverseInput(input);

            //get the sum
            sum = Logik.NumberHandler.AddNumbers(input, output);

            //write output to console
            Console.WriteLine(counter.ToString() + ". " + input.ToString() + " + " + output.ToString() + " = " + sum.ToString());
            
            //count up
            counter++;

            if (input != output)
                ProcessNumber(sum, counter);
        }
    }
}

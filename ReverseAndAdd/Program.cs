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

            //get the input integer
            int input = 0;
            int.TryParse(Console.ReadLine(), out input);
            //TODO: handle bad input

            //reverse the number
            int output = Logik.NumberHandler.ReverseInput(input);

            //write output to console
            Console.WriteLine(input.ToString() + " + " + output.ToString() + " = " + (input + output).ToString());

            //wait
            Console.ReadLine();
        }
    }
}

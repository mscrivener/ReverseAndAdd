using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAndAdd.Logik
{
    public static class NumberHandler
    {
        /// <summary>
        /// Reverses the input integer and returns it
        /// Assumption: the input is a positive integer
        /// </summary>
        /// <param name="input"></param>
        /// <returns>the integer reversed</returns>
        public static long ReverseInput(long input)
        {
            //turn input into string, then array of char
            char[] original = input.ToString().ToCharArray();

            //reverse char array
            Array.Reverse(original);

            //convert to int
            long reversed = 0;
            long.TryParse(new string(original), out reversed);
            //TODO: handle if this goes wrong

            //return integer value of reverse char array
            return reversed;

        }

        /// <summary>
        /// Adds the two numbers together and return the sum
        /// </summary>
        /// <param name="original"></param>
        /// <param name="reversed"></param>
        /// <returns>sum</returns>
        public static long AddNumbers(long original, long reversed)
        {
            return original + reversed;
        }

        
       
    }
}

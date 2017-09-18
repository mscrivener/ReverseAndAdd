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
        public static ulong ReverseInput(ulong input)
        {
            //turn input into string, then array of char
            char[] original = input.ToString().ToCharArray();

            //reverse char array
            Array.Reverse(original);

            //convert to int
            ulong reversed = 0;
            if (!ulong.TryParse(new string(original), out reversed))
                throw new Exception("The reverse number is greater than " + (ulong.MaxValue).ToString());
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
        public static ulong AddNumbers(ulong original, ulong reversed)
        {
            if (original + reversed > ulong.MaxValue)
                throw new Exception("The sum of " + original.ToString() + " and " + reversed.ToString() + " is greater than " + (ulong.MaxValue).ToString());
            return original + reversed;
        }
        
        /// <summary>
        /// Compares two values and returns true if they're identical
        /// </summary>
        /// <param name="original"></param>
        /// <param name="reversed"></param>
        /// <returns>are the two numbers the same?</returns>
        public static bool IsPalindrome(ulong original, ulong reversed)
        {
            //
            return original == reversed;
        }
    }
}

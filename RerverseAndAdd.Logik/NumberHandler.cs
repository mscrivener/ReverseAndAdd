﻿using System;
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
        public static int ReverseInput(int input)
        {
            //turn input into string, then array of char
            char[] original = input.ToString().ToCharArray();

            //reverse char array
            Array.Reverse(original);

            //convert to int
            int reversed = 0;
            int.TryParse(new string(original), out reversed);
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
        public static int AddNumbers(int original, int reversed)
        {
            return original + reversed;
        }

        
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// This class is called by the other classes whenever we need an integer or a double read from console.
    /// It will also check if the input was a valid entry
    /// Oskar Enmalm 2016.10.06 - With guidance from the assignment instructions
    /// </summary>
    class Input
    {
        /// <summary>
        /// Takes user input
        /// </summary>
        /// <returns>Integer</returns>
        public static int ReadIntegerConsole()
        {
            int input;
            if (int.TryParse(Console.ReadLine(), out input)) return input;
            else Console.WriteLine("Please enter a valid input>>");

            return ReadIntegerConsole(); //will run the method again until a valid input is stored

        }

        /// <summary>
        /// Takes user input
        /// </summary>
        /// <returns>double</returns>
        public static double ReadDoubleConsole()
        {
            double input;
            if (double.TryParse(Console.ReadLine(), out input)) return input;
            else Console.WriteLine("Please enter a valid input. Remember ',' represents the decimal>>");

            return ReadDoubleConsole();
        }


    }
}

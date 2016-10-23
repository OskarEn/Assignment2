using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// Will take in user input and add it to a sum
    /// When the user inputs 0 it will print the sum 
    /// </summary>
    class FloatingPointsNumberWhileAdd
    {
        private double sum; //the sum which will be added to whilst class is running

        public void Start()
        {
            WriteProgramInfo();
            InputAndSumNumbers();//checking if the input is 0, if not it adds input to sum
            WriteResult();
        }

        private void WriteProgramInfo()
        {
            Console.WriteLine("\n\n+++++Summation of Floats+++++");
            Console.WriteLine("\t\tUsing a while-statement\n");
        }

        private void InputAndSumNumbers()
        {
            //checks constantly whether the user has entered zero, will round anything smaller that 1x10^7 to 0
            bool done = false; 

            while(!done)
            {
                Console.Write("\tWrite an amount to sum or press 0 to finish: ");
                double userInput = Input.ReadDoubleConsole();
                if ((Math.Round( userInput, 7) == 0.0))
                {
                    done = true;
                }
                else sum += userInput; 
            }

        }
        private void WriteResult()
        {
            {

                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");
                Console.WriteLine("Sum = {0}", sum);
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n\n\n");
            }
        }

    }//end of class
}//end of namespace

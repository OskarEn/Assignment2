using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// This class asks for the amount of integers a user wants to add which will allow the user to
    /// enter the said amount. The total will then be displayed.
    /// Oskar Enmalm 2016.10.07
    /// modified: 2016.10.08
    /// </summary>
    class WholeNumbersForAdd
    {
        private int total;

        public void Start()
        {
            WriteProgramInfo(); //Title           
            SumNumbers(); //Will do the calculation
            WriteResult(); //Displays the result for the user
        }

        private void WriteProgramInfo()
        {
            Console.WriteLine("\n\n+++++Summation of Whole Numbers+++++");
            Console.WriteLine("\t\tUsing a for-statement\n");
        }

        private void SumNumbers()
        {
            Console.Write("Enter the amount of integers you want to sum: ");
            int amount = Input.ReadIntegerConsole(); //calling available method to check input, used for array
                                                     // string[] mySumQuestions = new string[amount];//using this to help with the "please give value number {x++}
            

            int x = 1; //int to help with out loop
            for (x = 1; x <= amount; ++x) //start the for loop  
            {
                Console.Write("Please enter number {0}:\t", x);
                //removed the summing of array, implemented a simple totaler
                //int[] mySum = new int[amount]; //Initilizing a ray of amount size;
                /*will write the prompt for the user
                // int arrayPosition = 1; //need to review this, only shows the last position
                // mySum[arrayPosition] = Input.ReadIntegerConsole();
                arrayPosition++;
                total = mySum.Sum(); //takes the total of the */
                total = total + Input.ReadIntegerConsole();     
                
            }
             
            
        }


          private void WriteResult()
        {
            
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");
            Console.WriteLine("Sum = {0}", total);
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n\n\n");
        }
    }//class
}//namespace

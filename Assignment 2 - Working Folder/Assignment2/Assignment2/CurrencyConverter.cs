using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// This is the FloatingPointNumberWhileAdd class but with the extra features of asking the user 
    /// at the end what the given currency was what they want 
    /// it will ask for the conversion rate and use this to print the equivalent in the other currency
    /// Oskar Enmalm 2016.10.09
    /// Reviewed 2016.10.11
    /// </summary>
    class CurrencyConverter
    {
        private double sum, exchangeRate; //the sum which will be added to whilst class is running
        private decimal finalAmount;
        private string endCurrency;

        public void Start()
        {
            WriteProgramInfo();
            InputAndSumNumbers();//checking if the input is 0, if not it adds input to sum
            CalculateExchange();
            WriteResult();
        }

        private void WriteProgramInfo()
        {
            Console.WriteLine("\n\n+++++Currency Converter+++++");
            Console.WriteLine("\t\tUsing a do-while statement\n");
        }

        private void InputAndSumNumbers()
        {
            //checks constantly whether the user has entered zero, will round anything smaller that 1x10^7 to 0
            bool done = false;

            do
            {
                Console.Write("\tWrite an amount to sum or press 0 to finish: ");
                double userInput = Input.ReadDoubleConsole();
                if ((Math.Round(userInput, 7) == 0.0))
                {
                    done = true;
                }
                else sum += userInput;
            } while (!done);

        }

        private void CalculateExchange()
        {
            Console.Write("To what currency are you exchanging? ");
            endCurrency = Console.ReadLine();
            Console.Write("What is the current local currency to? ", endCurrency);
            exchangeRate = Input.ReadDoubleConsole(); 
            

            finalAmount = Convert.ToDecimal(sum * exchangeRate);//converting to decimal as specified by assignment
            
        }

        private void WriteResult()
        {
            {

                Console.WriteLine("\n\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");
                Console.WriteLine("{0:C} can be exchanged to {1:f2} {2}(s) with an exchange rate of {3:C}/{4}",
                    sum, finalAmount, endCurrency, exchangeRate, endCurrency);
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n\n\n");
            }
        }
    }//end of class
}//end of namespace

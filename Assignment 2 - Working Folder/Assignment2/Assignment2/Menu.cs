using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment2
{
    /// <summary>
    /// This is the Menu class. It is a loop where the user returns to unless the '0' is selected
    /// It will give 4 options to the user, depending on what calculation the user wants to make
    /// Oskar Enmalm 2016.10.06
    /// </summary>
    class Menu
    {
        public void start()
        {
            int choice = -1; //initialises as -1 because 0 is used to exit

            while (choice != 0) //start of the while loop
            {
                WriteMenuText(); //displays the menu
                choice = Input.ReadIntegerConsole(); //flexible method to use to read input
                Console.WriteLine("Your choice : [{0}]", choice);

                switch (choice) //It came up in the assignments that arrays can be used, don't think this is the right time
                {
                    case 1: //for statement. Complete
                        {
                            WholeNumbersForAdd sumObj = new WholeNumbersForAdd();
                            sumObj.Start();
                            break;
                        }
                
                    case 2: //While statement
                              { FloatingPointsNumberWhileAdd doubleObj = new FloatingPointsNumberWhileAdd();
                            doubleObj.Start();
                            break;
                        }

                    case 3: //Do While statement
                              { CurrencyConverter currencyObj = new CurrencyConverter();
                            currencyObj.Start();
                            break;
                        }

                    case 4: //Undecided - will be several itterations and outputs. Do while as it is executed until it reaches 52?
                              { WorkingSchedule scheduleObj = new WorkingSchedule();
                            scheduleObj.Start();
                            break;
                        }
 
                    case 5: //creating a table with temperature values from formula
                             { TemperatureTable temperatureObj = new TemperatureTable();
                            temperatureObj.Start();
                            break;
                        }
                }
            }
            }

        private void WriteMenuText() //method to display options for choice
            //did the formatting manually, look forward to using windows forms.
        {
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-MENU-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.WriteLine("\t Whole Numbers with For\t\t\t\t : [1]");
            Console.WriteLine("\t Floating Point Numbers with While \t\t : [2]");
            Console.WriteLine("\t Currency Converter with Do While Loop\t\t : [3]");
            Console.WriteLine("\t Work Schedule\t\t\t\t\t : [4]\n");
            Console.WriteLine("\t Temperature table\t\t\t\t : [5]\n");
            Console.WriteLine("\t Exit the Program\t\t\t\t : [0]");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");

        }

    }//end of class
   
    
}//end of namespace

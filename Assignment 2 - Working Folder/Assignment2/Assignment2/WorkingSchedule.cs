using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class WorkingSchedule
    {
        /// <summary>
        /// This class is for a user that is working every 3rd weekend, and having a night shift every 5th starting
        /// on week 6.
        /// The schedule will cover one year period of 52 weeks
        /// The menu will be a while loop where the user can pick 
        /// 1 for weekends
        /// 2 for nights
        /// 0 to exit to the main menu
        /// The program should show the weeks needed to work in a table 3 columns wide for easy reading.
        /// Oskar Enmalm 2016.10.11
        /// Reviewed 2016.10.12
        /// </summary>

       private bool isZero = false;
       private int choice; //the choice which will customise the results printed
       // private int[] shifts;

        public void Start()
        {
            while (!isZero)
            {
                WriteProgramInfo();
                ReadingInput();
                //PrintResults();
            }
        }

        private void WriteProgramInfo()
        {
            Console.WriteLine("\n\n+++++Your Working Schedule+++++");
            Console.WriteLine("\t\tSelect the number for which schedule you want to access");
        }

        private void ReadingInput()
        {
            WriteMenuText(); //displays the menu
            choice = Input.ReadIntegerConsole(); //flexible method to use to read input
            Console.WriteLine("Your choice : [{0}]", choice);

            if (choice == 0)
            {
                isZero = true;
            }
            switch (choice)
            {
                case 1: //The weekend schedule
                    {
                        Console.WriteLine("You are working Weekends :\n");
                        int x = 1;
                        while(x<=52)
                        {
                            Console.WriteLine("Week\t [{0}]", x);
                            x += 3;
                        }
                        break;
                   //trying a more elegant solution
                   //I declared the array at the beginning, but was not able to Write the results in the next method
                       /* int weeks = 1;//starting week
                        int loop = 1;//starting position of the first array entry
                        while (weeks <= 52)
                        {
                            shifts = new int[]{ weeks };
                            //shifts[loop] = weeks;
                            weeks += 3;
                            loop++;
                        }

                        break;*/

                    }

                case 2: //The nights schedule
                    {
                        Console.WriteLine("You are working night shifts :");
                        int x = 6;
                        while (x <= 52)
                            {
                            Console.WriteLine("Week\t\t [{0}]", x);
                            x += 5;
                            }
                          break;
                        }           
            }//switch
        }//read input

        private void WriteMenuText() //The menu text
        {
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.WriteLine("\t Weekend Schedule : [1]");
            Console.WriteLine("\t Night Schedule   : [2]");
            Console.WriteLine("\t Exit the Schedule: [0]");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");
        }         

      /*  private void PrintResults()
        {

                Console.WriteLine("You are working {0}", scheduleName);
                Console.WriteLine("\n Week [{0}] ", shifts);
        }*/

        /*private void PrintResults()
        {
            foreach (int weeks in shifts)
                Console.WriteLine("Week [{0}]", weeks.ToString());
        }*/

    }//end of class
}//end of namespace

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// A table that displays values from 0 to 100 degrees in Fahrenheit.
    /// Changing Fahrenheit whole number to Celcius (2 decimal points)
    /// From 0F to 100F in increments of 4
    /// Oskar Enmalm 2016.10.08
    /// Reviewed 2016.10.12
    /// </summary>
    class TemperatureTable
    {
        private int fahTemp;

        public void Start()
        {
            ProgramInfo();
            PrintTable();
        }

        private void ProgramInfo()
        {
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.WriteLine("\t Temperature Table");
            Console.WriteLine("\t Fahrenheit to Celcius");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");
        }

        private void PrintTable()
        {
            double fahTemp = 0;
            
            while (fahTemp <= 100)
            {
                double toCelcius = 5.0 / 9.0 * (fahTemp - 32);
                Console.WriteLine("\t{0}F\t\t =\t {1:f2} Celcius", fahTemp, toCelcius);
                fahTemp += 4;
            }
            Console.WriteLine("\n Press any key to return to menu!");
            Console.ReadKey();
        }
        
    //  toCelsius = 5.0 / 9.0 * (valueToConvert - 32)
      // int toFahrenheit = 9.0 / 5.0 * valueToConvert + 32.0*/
    }
}

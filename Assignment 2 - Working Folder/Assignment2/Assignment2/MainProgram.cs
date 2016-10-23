using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// This the main method which will create an object and call the Menu method.
    /// Oskar Enmalm 2016.10.06
    /// </summary>
    class MainProgram
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.start();
        }
    }
}

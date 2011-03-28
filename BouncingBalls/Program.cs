// By: Erik Hanchett
// Date:3/28/2011
// Assignment: #5
// Exercise Multithreading

// Entry point to program. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BouncingBalls
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BouncingBallMain());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CycloComputer_GUI
{
    static class Program
    {
        public static Tachometr Tachometr
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void NastaveniObvoduKola()
        {
            throw new System.NotImplementedException();
        }

        public static void NastaveniRezimuCasu()
        {
            throw new System.NotImplementedException();
        }

        public static void ZobrazeniDat()
        {
            throw new System.NotImplementedException();
        }
    }
}

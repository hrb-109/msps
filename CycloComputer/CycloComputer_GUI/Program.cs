using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CycloComputer;

namespace CycloComputer_GUI
{
    class Program
    {
        private static int iclick=0;

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

        public static int ZobrazeniDat()
        {
            click++;

            if (click > 5)
            {
                click = 0;
            }
            return click;
        }

        public static int click { get { return iclick; } set { iclick = value; } }
    }
}

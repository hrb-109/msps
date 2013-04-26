using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace CycloComputer_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //zmenit_mod(0);
            clear();
            InitTimer();
        }

        CycloComputer.Tachometr tach = new CycloComputer.Tachometr();
        
        private void button1_Click(object sender, EventArgs e)
        {
            zmenit_mod(Program.ZobrazeniDat()); 
        }

        int mode = 0;
        double prumerna_rychlost=0;

        public void zmenit_mod(int mod)
        {
            if (checkBox_zapnuti_tachometr.Checked == true)
            {
                if (mod == 0)
                {
                    label1.Text = "Celkový čas";
                    label2.Text = "Celková ujetá vzdálenost";
                    label3.Text = "Teplota okolí";

                    label_hodnota1.Text = "";
                    label_hodnota2.Text = "";
                    label_hodnota3.Text = tach.GetTeplota().ToString();

                    mode = 0;
                }
                else if (mod == 1)
                {
                    label1.Text = "Aktualní rychlost";
                    label2.Text = "Maximální dosažená rychlost";
                    label3.Text = "Průměrná rychlost";

                    label_hodnota1.Text = "";
                    label_hodnota2.Text = "";
                    label_hodnota3.Text = "";

                    mode = 1;
                }
                else if (mod == 2)
                {
                    label1.Text = "Ujetá vzdálenost";
                    label2.Text = "Celková ujetá vzdálenost";
                    label3.Text = "Čas výletu";

                    label_hodnota1.Text = "";
                    label_hodnota2.Text = "";
                    label_hodnota3.Text = "";

                    mode = 2;
                }
                else if (mod == 3)
                {
                    mode = 3;

                    label1.Text = "Kadence šlapání";
                    label2.Text = "";
                    label3.Text = "";

                    label_hodnota1.Text = tach.GetKadence().ToString();
                    label_hodnota2.Text = "";
                    label_hodnota3.Text = "";
                }
                else if (mod == 4)
                {
                    mode = 4;

                    label1.Text = "Tepová frekvence";
                    label2.Text = "";
                    label3.Text = "";

                    label_hodnota1.Text = "";
                    label_hodnota2.Text = "";
                    label_hodnota3.Text = "";
                }
                else
                {
                    mode = 5;

                    label1.Text = "Ujetá vzdálenost";
                    label2.Text = "Čas výletu";
                    label3.Text = "Aktuální rychlost";

                    label_hodnota1.Text = "";
                    label_hodnota2.Text = "";
                    label_hodnota3.Text = "";
                }
            }
        }

        private System.Windows.Forms.Timer timer1;
        private double max_rychlost = 0;

        public void InitTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = tach.intervalZiskavaniDat;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float kadence = tach.GetKadence();
            double rychlost = (kadence * 28 * 2.5757 * 3.6 * 8.25 / 6000);

            if (prumerna_rychlost == 0)
            {
                prumerna_rychlost = rychlost;
            }
            else
            {
                prumerna_rychlost = (prumerna_rychlost + rychlost) / 2;
            }

            if (mode == 1)
            {              
                label_hodnota1.Text = rychlost.ToString();
                label_hodnota2.Text = max_rychlost.ToString();
                label_hodnota3.Text = prumerna_rychlost.ToString();
            }

            if (mode == 3)
            {
                label_hodnota1.Text = kadence.ToString();
            }


            if (mode == 5)
            {
                label_hodnota3.Text = rychlost.ToString();
            }
            if (rychlost > max_rychlost)
            {
                max_rychlost = rychlost;
            }        
        }

        private void checkBox_zapnuti_tachometr_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_zapnuti_tachometr.Checked == true)
            {
                zmenit_mod(0);
            }
            else
            {
                clear();
            }
        }

        public void clear()
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";

            label_hodnota1.Text = "";
            label_hodnota2.Text = "";
            label_hodnota3.Text = "";
        }
    }
}

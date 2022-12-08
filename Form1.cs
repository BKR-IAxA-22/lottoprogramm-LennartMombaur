using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottoprogramm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] lottozahlen = new int[6];
        int[] lottozahlen2 = new int[6];
        TextBox[] textBoxes = new TextBox[6];   
        Random zahlengen = new Random();
        bool losen = false;

        public void auslosen_Click(object sender, EventArgs e)
        {
            losen = true;

            if (losen == true && eingabe1.Text != "" && eingabe2.Text != "" && eingabe3.Text != "" && eingabe4.Text != "" && eingabe5.Text != "" && eingabe6.Text != "")
            {
                for (int i = 0; i < lottozahlen.Length; i++)
                {
                    bool treffer = false;
                    int x = zahlengen.Next(1, 49);
                    if (lottozahlen.Contains(x))
                    {
                        i--;
                    }
                    else
                    {
                        lottozahlen[i] = x;

                    }
                    zahl1.Text = Convert.ToString(lottozahlen[0]);
                    zahl2.Text = Convert.ToString(lottozahlen[1]);
                    zahl3.Text = Convert.ToString(lottozahlen[2]);
                    zahl4.Text = Convert.ToString(lottozahlen[3]);
                    zahl5.Text = Convert.ToString(lottozahlen[4]);
                    zahl6.Text = Convert.ToString(lottozahlen[5]);
                    for (int y = 0; y < lottozahlen2.Length; y++)
                    {
                        if (lottozahlen[i] == lottozahlen[y])

                            treffer = true;

                    }
                    if(treffer == true)
                    {
                     textBoxes[i].BackColor=Color.Lime;
                    }
                } 
            }

            //Ausgabe
           
            //Eingabe
            eingabe1.Text = Convert.ToString(lottozahlen2[0]);
            eingabe2.Text = Convert.ToString(lottozahlen2[1]);
            eingabe3.Text = Convert.ToString(lottozahlen2[2]);
            eingabe4.Text = Convert.ToString(lottozahlen2[3]);
            eingabe5.Text = Convert.ToString(lottozahlen2[4]);
            eingabe6.Text = Convert.ToString(lottozahlen2[5]);

            überschriftausgabe.Text = Convert.ToString("Die Lottozahlen vom " + DateTime.Now);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            überschriftausgabe.Text = Convert.ToString("Die Lottozahlen vom " + DateTime.Now);
            überschrifteingabe.Text = Convert.ToString("Deine Lottozahlen");
        }

        private void zahl1_TextChanged(object sender, EventArgs e)
        {

        }

        private void zahl2_TextChanged(object sender, EventArgs e)
        {

        }

        private void zahl3_TextChanged(object sender, EventArgs e)
        {

        }

        private void zahl4_TextChanged(object sender, EventArgs e)
        {

        }

        private void zahl5_TextChanged(object sender, EventArgs e)
        {

        }

        private void zahl6_TextChanged(object sender, EventArgs e)
        {

        }

        private void eingabe1_TextChanged(object sender, EventArgs e)
        {

        }

        private void eingabe2_TextChanged(object sender, EventArgs e)
        {

        }

        private void eingabe3_TextChanged(object sender, EventArgs e)
        {

        }

        private void eingabe4_TextChanged(object sender, EventArgs e)
        {

        }

        private void eingabe5_TextChanged(object sender, EventArgs e)
        {

        }

        private void eingabe6_TextChanged(object sender, EventArgs e)
        {

        }

        private void überschriftausgabe_TextChanged(object sender, EventArgs e)
        {

        }

        private void überschrifteingabe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

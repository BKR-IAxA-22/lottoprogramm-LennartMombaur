using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        int[] lottozahlen= new int[6];
        Random zahlengen = new Random();
        int zahlenbereich = 49;
        bool losen=false;
        public void auslosen_Click(object sender, EventArgs e)
        {
            losen = true;
            if (losen == true)
            {
                for (int i = 0; i < lottozahlen.Length; i++)
                {
                   lottozahlen[i] = zahlengen.Next();

                }
            }
            else
            {
                for (int i = 1; i < lottozahlen.Length; i++)
                {
                    lottozahlen[i] = i;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            zahl1.Text = Convert.ToString(lottozahlen[0]);
            zahl2.Text = Convert.ToString(lottozahlen[1]);
            zahl3.Text = Convert.ToString(lottozahlen[2]);
            zahl4.Text = Convert.ToString(lottozahlen[3]);
            zahl5.Text = Convert.ToString(lottozahlen[4]);
            zahl6.Text = Convert.ToString(lottozahlen[5]);
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
    }
}

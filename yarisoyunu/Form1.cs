using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yarisoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rand1 = rnd.Next(0, 10);
            p1.Left += rand1;

            int rand2 = rnd.Next(0, 10);
            p2.Left += rand2;

            if(p1.Right>=panel1.Left || p2.Right>=panel1.Left)
            {
                timer1.Stop();
                if (p1.Left > p2.Left)
                {
                    MessageBox.Show("tebrikler 1. oyuncu yarısı kazandı.");
                }
                else
                {
                    MessageBox.Show("tebrikler 2. oyuncu yarısı kazandı.");
                }              
            }
        }
        private void start_Click(object sender, EventArgs e)
        {
            p1.Left = 0;
            p2.Left = 0;
            //tekrar start edildiğinde konumları en basa alır bastan baslatır.

            timer1.Start();

        }
    }
}

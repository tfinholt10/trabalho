using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuerraMundial.Deskview
{
    public partial class Form2 : Form
    {
        private int pro;

        public Form2()
        {
            InitializeComponent();
            pro = 0;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pro == 0)
            {
                bar.Value = 20;
                label2.Text = "Carregando questionário";
                pro = 20;
            }
            else if (pro == 20)
            {
                bar.Value = 40;
                label2.Text = "Carregando questionário";
                pro = 40;
            }
            else if (pro == 40)
            {
                bar.Value = 60;
                label2.Text = "Carregando questionário";
                pro = 60;
            }
            else if (pro == 60)
            {
                bar.Value = 80;
                label2.Text = "Carregando questionário";
                pro = 80;
            }
            else if (pro == 80)
            {
                bar.Value = 100;
                label2.Text = "Carregando questionário";
                pro = 100;
            }
            else if (pro == 100)
            {
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void bar_Click(object sender, EventArgs e)
        {

        }
    }
}

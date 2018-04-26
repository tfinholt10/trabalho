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
    public partial class 
        Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 tela = new Form2();
            tela.ShowDialog();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 10;
            if (this.Opacity == 100)
            {
                timer1.Enabled = false;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void qver01_Click(object sender, EventArgs e)
        {
           
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void qver01_Click_1(object sender, EventArgs e)
        {
           // if (qver01.Enabled == true)            
            panel1.Visible = false;

            panel2.Visible = true;
            
            

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

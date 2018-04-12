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

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {

                q02opcao02.ForeColor = Color.Green;
            }
            else if (radioButton1.Checked == true)
            {
                radioButton2.ForeColor = Color.Green;
                radioButton1.ForeColor = Color.Red;

            }
            else if (radioButton3.Checked == true)
            {
                radioButton2.ForeColor = Color.Green;
                radioButton3.ForeColor = Color.Red;

            }
            else if (radioButton4.Checked == true)
            {
                radioButton2.ForeColor = Color.Green;
                radioButton4.ForeColor = Color.Red;

            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

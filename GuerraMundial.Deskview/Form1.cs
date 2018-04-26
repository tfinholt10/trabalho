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
        int nota = 0;
        //string res = Convert.ToString(nota);
 

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
            if (p1c2.Checked == true)
            {
                nota = nota + 1;
            }
            
            

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel4.Visible = true;
            if (radioButton2.Checked == true)
            {
                nota = nota + 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel3.Visible = true;
            if (radioButton5.Checked == true)
            {
                nota = nota + 1;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel5.Visible = true;
            if (radioButton12.Checked == true)
            {
                nota = nota + 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel6.Visible = true;
            if (radioButton14.Checked == true)
            {
                nota = nota + 1;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel7.Visible = true;
            if (radioButton19.Checked == true)
            {
                nota = nota + 1;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel8.Visible = true;
            if (radioButton23.Checked == true)
            {
                nota = nota + 1;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
            panel9.Visible = true;
            if (radioButton28.Checked == true)
            {
                nota = nota + 1;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            panel10.Visible = true;
            if (radioButton32.Checked == true)
            {
                nota = nota + 1;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            panel10.Visible = false;
            panel11.Visible = true;
            if (radioButton33.Checked == true)
            {
                nota = nota + 1;
            }
        }

        private void label66_Click(object sender, EventArgs e)
        {
            label66.Text = "Você acertou o total de";
            label61.Text = Convert.ToString(nota);
            label62.Text = "questões!";
        }

        private void label60_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

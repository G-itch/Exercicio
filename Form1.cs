using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label11.Image = null;
            label11.BackColor = Color.FromArgb(46, 64, 87);
            leftpanel.BackColor = Color.FromArgb(244, 91, 105);
            leftpanel.Height = buttondiv.Height;
            leftpanel.Top = buttondiv.Top;
            label3.Text = "Você escolheu elevar";
            Task.Delay(2000).Wait();
            label3.Text = "";
            label4.Text = "Sorteando os números...";
            Task.Delay(1000).Wait();
            List<int> lista = new List<int>();
            for (int i = 0; i <= 1; i++)
            {
                Random randNum = new Random();
                int j = randNum.Next(1,10);
                if (j == 0)
                {
                    if (i == 0)
                    {

                        label5.Image = Properties.Resources._0_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._0_100px;
                    }
                }
                if (j == 1)
                {
                    if (i == 0)
                    {

                        label5.Image = Properties.Resources._1_100px1;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._1_100px1;
                    }
                }
                if (j == 2)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._2_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._2_100px;
                    }

                }
                if (j == 3)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._3_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._3_100px;
                    }

                }
                if (j == 4)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._4_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._4_100px;
                    }
                }

                if (j == 5)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._5_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._5_100px;
                    }
                }

                if (j == 6)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._6_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._6_100px;
                    }
                }
                if (j == 7)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._7_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._7_100px;
                    }
                }
                if (j == 8)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._8_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._8_100px;
                    }
                }
                if (j == 9)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._9_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._9_100px;
                    }
                }
                if (j == 10)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._10_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._10_100px;
                    }

                }
                if (i == 0)
                {
                    label8.Text = j.ToString();
                }
                else
                {
                    label9.Text = j.ToString();
                }
                lista.Add(j);
            Task.Delay(1500).Wait();
            }
            label4.Text = "";
            label7.Text = "Qual o resultado da \n elevação dos dois \n números?";
            label10.Text = "e";
            textBox1.BackColor = Color.FromArgb(255, 255,255);
            button1.Visible = true;
            button1.BackColor = Color.FromArgb(219, 255, 118);
            button1.Text = "Verificar";
            button1.Image = Properties.Resources.tiktok_verified_account_35px;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label11.Image = null;
            label11.BackColor = Color.FromArgb(46, 64, 87);
            leftpanel.BackColor = Color.FromArgb(244, 91, 105);
            leftpanel.Height = buttonsub.Height;
            leftpanel.Top = buttonsub.Top;
            label3.Text = "Você escolheu Subtração";
            Task.Delay(2000).Wait();
            label3.Text = "";
            label4.Text = "Sorteando os números...";
            Task.Delay(1000).Wait();
            List<int> lista = new List<int>();
            for (int i = 0; i <= 1; i++)
            {
                Random randNum = new Random();
                int j = randNum.Next(10);
                if (j == 0)
                {
                    if (i == 0)
                    {

                        label5.Image = Properties.Resources._0_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._0_100px;
                    }
                }
                if (j == 1)
                {
                    if (i == 0)
                    {

                        label5.Image = Properties.Resources._1_100px1;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._1_100px1;
                    }
                }
                if (j == 2)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._2_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._2_100px;
                    }

                }
                if (j == 3)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._3_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._3_100px;
                    }

                }
                if (j == 4)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._4_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._4_100px;
                    }
                }

                if (j == 5)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._5_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._5_100px;
                    }
                }

                if (j == 6)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._6_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._6_100px;
                    }
                }
                if (j == 7)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._7_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._7_100px;
                    }
                }
                if (j == 8)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._8_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._8_100px;
                    }
                }
                if (j == 9)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._9_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._9_100px;
                    }
                }
                if (j == 10)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._10_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._10_100px;
                    }

                }
                if (i == 0)
                {
                    label8.Text = j.ToString();
                }
                else
                {
                    label9.Text = j.ToString();
                }

                Task.Delay(1500).Wait();
            }
            label4.Text = "";
            label7.Text = "Qual o resultado da \n subtração dos dois \n números?";
            label10.Text = "s";
            textBox1.BackColor = Color.FromArgb(255, 255, 255);
            button1.Visible = true;
            button1.BackColor = Color.FromArgb(219, 255, 118);
            button1.Text = "Verificar";
            button1.Image = Properties.Resources.tiktok_verified_account_35px;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label11.Image = null;
            label11.BackColor = Color.FromArgb(46, 64, 87);
            leftpanel.BackColor = Color.FromArgb(244, 91, 105);
            leftpanel.Height = buttonadd.Height;
            leftpanel.Top = buttonadd.Top;
            label3.Text = "Você escolheu Adição";
            Task.Delay(2000).Wait();
            label3.Text = "";
            label4.Text = "Sorteando os números...";
            Task.Delay(1000).Wait();
            List<int> lista = new List<int>();
            for (int i = 0; i <= 1; i++)
            {
                Random randNum = new Random();
                int j = randNum.Next(10);
                if (j == 0)
                {
                    if (i == 0)
                    {

                        label5.Image = Properties.Resources._0_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._0_100px;
                    }
                }
                if (j == 1)
                {
                    if (i == 0)
                    {

                        label5.Image = Properties.Resources._1_100px1;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._1_100px1;
                    }
                }
                if (j == 2)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._2_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._2_100px;
                    }

                }
                if (j == 3)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._3_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._3_100px;
                    }

                }
                if (j == 4)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._4_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._4_100px;
                    }
                }

                if (j == 5)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._5_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._5_100px;
                    }
                }

                if (j == 6)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._6_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._6_100px;
                    }
                }
                if (j == 7)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._7_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._7_100px;
                    }
                }
                if (j == 8)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._8_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._8_100px;
                    }
                }
                if (j == 9)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._9_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._9_100px;
                    }
                }
                if (j == 10)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._10_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._10_100px;
                    }

                }
                if (i == 0)
                {
                    label8.Text = j.ToString();
                }
                else
                {
                    label9.Text = j.ToString();
                }
                Task.Delay(1500).Wait();
            }
            label4.Text = "";
            label7.Text = "Qual o resultado da \n adição dos dois \n números?";
            label10.Text = "a";
            textBox1.BackColor = Color.FromArgb(255, 255, 255);
            button1.Visible = true;
            button1.BackColor = Color.FromArgb(219, 255, 118);
            button1.Text = "Verificar";
            button1.Image = Properties.Resources.tiktok_verified_account_35px;

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonmult_Click(object sender, EventArgs e)
        {
            label11.Image = null;
            label11.BackColor = Color.FromArgb(46, 64, 87);
            leftpanel.BackColor = Color.FromArgb(244, 91, 105);
            leftpanel.Height = buttonmult.Height;
            leftpanel.Top = buttonmult.Top;
            label3.Text = "Você escolheu Multiplicação";
            Task.Delay(2000).Wait();
            label3.Text = "";
            label4.Text = "Sorteando os números...";
            Task.Delay(1000).Wait();
            List<int> lista = new List<int>();
            for (int i = 0; i <= 1; i++)
            {
                Random randNum = new Random();
                int j = randNum.Next(10);
                if (j == 0)
                {
                    if (i == 0)
                    {

                        label5.Image = Properties.Resources._0_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._0_100px;
                    }
                }
                if (j == 1)
                {
                    if (i == 0)
                    {

                        label5.Image = Properties.Resources._1_100px1;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._1_100px1;
                    }
                }
                if (j == 2)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._2_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._2_100px;
                    }

                }
                if (j == 3)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._3_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._3_100px;
                    }

                }
                if (j == 4)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._4_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._4_100px;
                    }
                }

                if (j == 5)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._5_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._5_100px;
                    }
                }

                if (j == 6)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._6_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._6_100px;
                    }
                }
                if (j == 7)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._7_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._7_100px;
                    }
                }
                if (j == 8)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._8_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._8_100px;
                    }
                }
                if (j == 9)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._9_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._9_100px;
                    }
                }
                if (j == 10)
                {
                    if (i == 0)
                    {
                        label5.Image = Properties.Resources._10_100px;
                    }
                    else
                    {
                        label6.Image = Properties.Resources._10_100px;
                    }

                }
                if (i == 0)
                {
                    label8.Text = j.ToString();
                }
                else
                {
                    label9.Text = j.ToString();
                }
                Task.Delay(1500).Wait();
            }
            label4.Text = "";
            label7.Text = "Qual o resultado da \n multiplicação dos dois \n números?";
            label10.Text = "m";
            textBox1.BackColor = Color.FromArgb(255,255,255);
            button1.Visible = true;
            button1.BackColor = Color.FromArgb(219, 255, 118);
            button1.Text = "Verificar";
            button1.Image = Properties.Resources.tiktok_verified_account_35px;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           
            double v1 = double.Parse(label8.Text);
            double v2 = double.Parse(label9.Text);
            double valor;
            double valor2;
            if (label10.Text == "s")
            {
                valor = v1 - v2;
                valor2 = v2 - v1;
                if (double.Parse(textBox1.Text) == valor || double.Parse(textBox1.Text) == valor2)
                {
                    label11.BackColor = Color.FromArgb(143, 247, 167);  
                    label11.Image = Properties.Resources.checkmark_80px;
                }
                else
                {
                    label11.BackColor = Color.FromArgb(255, 100, 120);
                    label11.Image = Properties.Resources.delete_80px;
                }
            }
            else if (label10.Text == "a") 
            {
                valor = v1 + v2;
                valor2 = v2 + v1;
                if (double.Parse(textBox1.Text) == valor || double.Parse(textBox1.Text) == valor2)
                {
                    label11.BackColor = Color.FromArgb(143, 247, 167);
                    label11.Image = Properties.Resources.checkmark_80px;
                }
                else
                {
                    label11.BackColor = Color.FromArgb(255, 100, 120);
                    label11.Image = Properties.Resources.delete_80px;
                }
            }
            else if (label10.Text == "m")
            {
                valor = v1 * v2;
                valor2 = v2 * v1;
                if (double.Parse(textBox1.Text) == valor || double.Parse(textBox1.Text) == valor2)
                {
                    label11.BackColor = Color.FromArgb(143, 247, 167);
                    label11.Image = Properties.Resources.checkmark_80px;
                }
                else
                {
                    label11.BackColor = Color.FromArgb(255, 100, 120);
                    label11.Image = Properties.Resources.delete_80px;
                }
            }
            else if (label10.Text == "e")
            {
                valor = Math.Pow(v1, v2);
                valor2 = Math.Pow(v2, v1);

                if (double.Parse(textBox1.Text) == valor || double.Parse(textBox1.Text) == valor2)
                {
                    label11.BackColor = Color.FromArgb(143, 247, 167);
                    label11.Image = Properties.Resources.checkmark_80px;
                }
                else
                {
                    label11.BackColor = Color.FromArgb(255, 100, 120);
                    label11.Image = Properties.Resources.delete_80px;
                }
            }
            label5.Image = null;
            label6.Image = null;
            label7.Text = "";
            textBox1.Text = "";
            textBox1.BackColor = Color.FromArgb(46, 64, 87);
            leftpanel.BackColor = Color.FromArgb(46, 64, 87);
            button1.BackColor = Color.FromArgb(46, 64, 87);
            button1.Visible = false;
            button1.Text = "";
            button1.Image = null;
            
  
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void painelresposta_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

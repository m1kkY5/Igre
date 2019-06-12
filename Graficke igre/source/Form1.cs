using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public int[,] sd = new int[5, 5];

        public TextBox[,] T = new TextBox[5, 5];

        public Form1()
        {
            InitializeComponent();
            gen(ref T);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbs(ref sd);
            l1.Text = sum(sd).ToString();
            textBox1.Enabled = false;
        }

        private void tbs(ref int[,] matrica)
        {
            #region TB

            T[0, 0].Text = textBox1.Text;
            T[0, 1].Text = textBox2.Text;
            T[0, 2].Text = textBox3.Text;
            T[0, 3].Text = textBox4.Text;
            T[0, 4].Text = textBox5.Text;

            T[1, 0].Text = textBox6.Text;
            T[1, 1].Text = textBox7.Text;
            T[1, 2].Text = textBox8.Text;
            T[1, 3].Text = textBox9.Text;
            T[1, 4].Text = textBox10.Text;

            T[2, 0].Text = textBox11.Text;
            T[2, 1].Text = textBox12.Text;
            T[2, 2].Text = textBox13.Text;
            T[2, 3].Text = textBox14.Text;
            T[2, 4].Text = textBox15.Text;

            T[3, 0].Text = textBox16.Text;
            T[3, 1].Text = textBox17.Text;
            T[3, 2].Text = textBox18.Text;
            T[3, 3].Text = textBox19.Text;
            T[3, 4].Text = textBox20.Text;

            T[4, 0].Text = textBox21.Text;
            T[4, 1].Text = textBox22.Text;
            T[4, 2].Text = textBox23.Text;
            T[4, 3].Text = textBox24.Text;
            T[4, 4].Text = textBox25.Text;

            oboj(sd, textBox1);
            oboj(sd, textBox2);
            oboj(sd, textBox3);
            oboj(sd, textBox4);
            oboj(sd, textBox5);

            oboj(sd, textBox6);
            oboj(sd, textBox7);
            oboj(sd, textBox8);
            oboj(sd, textBox9);
            oboj(sd, textBox10);

            oboj(sd, textBox11);
            oboj(sd, textBox12);
            oboj(sd, textBox13);
            oboj(sd, textBox14);
            oboj(sd, textBox15);

            oboj(sd, textBox16);
            oboj(sd, textBox17);
            oboj(sd, textBox18);
            oboj(sd, textBox19);
            oboj(sd, textBox20);

            oboj(sd, textBox21);
            oboj(sd, textBox22);
            oboj(sd, textBox23);
            oboj(sd, textBox24);
            oboj(sd, textBox25);

            #endregion

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrica[i, j] = int.Parse(T[i, j].Text);
                }
            }
        }

        private void gen(ref TextBox[,] T)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    T[i, j] = new TextBox();
                }
            }
        }

        private void oboj(int[,] matrica, TextBox tb)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrica[i, j] >= 10)
                    {
                        T[i,j].BackColor = Color.LightGreen;
                    }
                    else
                    {
                        T[i,j].BackColor = Color.Red;
                    }
                    tb.BackColor = T[i, j].BackColor;
                }
            }
            
        }

        private int sum(int[,] m)
        {
            int s = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    s += sd[i, j];
                }
            }
            return s;
        }

        
    }
}
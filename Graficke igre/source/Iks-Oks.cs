using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class iksoksF : Form
    {
        public int potez = 1;
        
        #region f
        public iksoksF()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = false;
            base.OnFormClosing(e);
        }

        void proveri()
        {
            //Nereseno
            if (p1.Text != "" && p2.Text != "" && p3.Text != "" &&
                p4.Text != "" && p5.Text != "" && p6.Text != "" &&
                p7.Text != "" && p8.Text != "" && p9.Text != "")
            {
                rezultat.Text = "Nereseno";
            }
            //Dijagonale X 
            if (p1.Text == "X" && p5.Text == "X" && p9.Text == "X" ||
                p3.Text == "X" && p5.Text == "X" && p7.Text == "X")
            {
                rezultat.Text = "Prvi";
                iskljuci();
            }
            //Redovi X
            if (p1.Text == "X" && p2.Text == "X" && p3.Text == "X" ||
                p4.Text == "X" && p5.Text == "X" && p6.Text == "X" ||
                p7.Text == "X" && p8.Text == "X" && p9.Text == "X")
            {
                rezultat.Text = "Prvi";
                iskljuci();
            }
            //Kolone X
            if (p1.Text == "X" && p4.Text == "X" && p7.Text == "X" ||
                p2.Text == "X" && p5.Text == "X" && p8.Text == "X" ||
                p3.Text == "X" && p6.Text == "X" && p9.Text == "X")
            {
                rezultat.Text = "Prvi";
                iskljuci();
            }

            //Dijagonale O
            if (p1.Text == "O" && p5.Text == "O" && p9.Text == "O" ||
                p3.Text == "O" && p5.Text == "O" && p7.Text == "O")
            {
                rezultat.Text = "Drugi";
                iskljuci();
            }
            //Redovi O
            if (p1.Text == "O" && p2.Text == "O" && p3.Text == "O" ||
                p4.Text == "O" && p5.Text == "O" && p6.Text == "O" ||
                p7.Text == "O" && p8.Text == "O" && p9.Text == "O")
            {
                rezultat.Text = "Drugi";
                iskljuci();
            }
            //Kolone O
            if (p1.Text == "O" && p4.Text == "O" && p7.Text == "O" ||
                p2.Text == "O" && p5.Text == "O" && p8.Text == "O" ||
                p3.Text == "O" && p6.Text == "O" && p9.Text == "O")
            {
                rezultat.Text = "Drugi";
                iskljuci();
            }
        }

        void iskljuci()
        {
            p1.Enabled = false;
            p2.Enabled = false;
            p3.Enabled = false;
            p4.Enabled = false;
            p5.Enabled = false;
            p6.Enabled = false;
            p7.Enabled = false;
            p8.Enabled = false;
            p9.Enabled = false;
        }

        #endregion

        #region Dugmad

        private void meni_Click(object sender, EventArgs e)
        {
            Meni meni = new Meni();
            meni.Show();
            this.Close();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            p1.Text = "";
            p2.Text = "";
            p3.Text = "";
            p4.Text = "";
            p5.Text = "";
            p6.Text = "";
            p7.Text = "";
            p8.Text = "";
            p9.Text = "";
            rezultat.Text = "";

            p1.Enabled = true;
            p2.Enabled = true;
            p3.Enabled = true;
            p4.Enabled = true;
            p5.Enabled = true;
            p6.Enabled = true;
            p7.Enabled = true;
            p8.Enabled = true;
            p9.Enabled = true;

            potez = 1;
        }

        #endregion

        #region Polja
       
        private void p1_Click_1(object sender, EventArgs e)
        {
            if (potez % 2 == 1)
            {
                p1.Text = "X";
                potez++;
            }
            else
            {
                p1.Text = "O";
                potez++;
            }
            p1.Enabled = false;
            proveri();
        }

        private void p2_Click_1(object sender, EventArgs e)
        {
            if (potez % 2 == 1)
            {
                p2.Text = "X";
                potez++;
            }
            else
            {
                p2.Text = "O";
                potez++;
            }
            p2.Enabled = false;
            proveri();
        }

        private void p3_Click_1(object sender, EventArgs e)
        {
            if (potez % 2 == 1)
            {
                p3.Text = "X";
                potez++;
            }
            else
            {
                p3.Text = "O";
                potez++;
            }
            p3.Enabled = false;
            proveri();
        }

        private void p4_Click_1(object sender, EventArgs e)
        {
            if (potez % 2 == 1)
            {
                p4.Text = "X";
                potez++;
            }
            else
            {
                p4.Text = "O";
                potez++;
            }
            p4.Enabled = false;
            proveri();
        }

        private void p5_Click_1(object sender, EventArgs e)
        {
            if (potez % 2 == 1)
            {
                p5.Text = "X";
                potez++;
            }
            else
            {
                p5.Text = "O";
                potez++;
            }
            p5.Enabled = false;
            proveri();
        }

        private void p6_Click_1(object sender, EventArgs e)
        {
            if (potez % 2 == 1)
            {
                p6.Text = "X";
                potez++;
            }
            else
            {
                p6.Text = "O";
                potez++;
            }
            p6.Enabled = false;
            proveri();
        }

        private void p7_Click_1(object sender, EventArgs e)
        {
            if (potez % 2 == 1)
            {
                p7.Text = "X";
                potez++;
            }
            else
            {
                p7.Text = "O";
                potez++;
            }
            p7.Enabled = false;
            proveri();
        }

        private void p8_Click_1(object sender, EventArgs e)
        {
            if (potez % 2 == 1)
            {
                p8.Text = "X";
                potez++;
            }
            else
            {
                p8.Text = "O";
                potez++;
            }
            p8.Enabled = false;
            proveri();
        }

        private void p9_Click_1(object sender, EventArgs e)
        {
            if (potez % 2 == 1)
            {
                p9.Text = "X";
                potez++;
            }
            else
            {
                p9.Text = "O";
                potez++;
            }
            p9.Enabled = false;
            proveri();
        }

        #endregion

        private void iksoksF_Load(object sender, EventArgs e)
        {

        }







    }
}

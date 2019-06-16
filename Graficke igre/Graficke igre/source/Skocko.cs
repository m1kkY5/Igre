using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class skockoF : Form
    {
        static int red = 0;
        static int kolona = 0;
        static int vreme = 120;
        
        static int[] kombinacijaInt;
        static string[] kombinacijaString;
        static string[] proveraString = new string[4];
        static Label[,] unosLabela = new Label[6, 4];
        static Label[,] bojaLabela = new Label[6, 4];
        static Random rnd = new Random();

        public skockoF()
        {
            InitializeComponent();

            gen_unosLabela(ref unosLabela);
            gen_bojaLabela(ref bojaLabela);
            gen(out kombinacijaInt);
            genS(out kombinacijaString);

            timeT.Enabled = true;
        }

        void gen_unosLabela(ref Label[,] unosLabela)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    unosLabela[i, j] = new Label();
                    unosLabela[i, j].Text = "";
                    unosLabela[i, j].Image = null;
                }
            }
        }

        void gen_bojaLabela(ref Label[,] bojaLabela)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    bojaLabela[i, j] = new Label();
                    bojaLabela[i, j].BackColor = Color.LightSkyBlue;
                }
            }
        }

        void gen(out int[] kombinacijaInt)
        {
            kombinacijaInt = new int[4];
            for (int i = 0; i < 4; i++)
                kombinacijaInt[i] = rnd.Next(1, 7);
        }

        void genS(out string[] kombinacijaString)
        {
            kombinacijaString = new string[4];
            string[] nums = { "1", "2", "3", "4", "5", "6"};

            kombinacijaString[0] = nums[kombinacijaInt[0] - 1];
            kombinacijaString[1] = nums[kombinacijaInt[1] - 1];
            kombinacijaString[2] = nums[kombinacijaInt[2] - 1];
            kombinacijaString[3] = nums[kombinacijaInt[3] - 1];
        }

        void unosLabela_Znak(int kolona, int red)
        {
            if (kolona == 0)
            {
                label1.Text = unosLabela[0, 0].Text;
                label2.Text = unosLabela[0, 1].Text;
                label3.Text = unosLabela[0, 2].Text;
                label4.Text = unosLabela[0, 3].Text;

                label1.Image = unosLabela[0, 0].Image;
                label2.Image = unosLabela[0, 1].Image;
                label3.Image = unosLabela[0, 2].Image;
                label4.Image = unosLabela[0, 3].Image;
            }

            if (kolona == 1)
            {
                label5.Text = unosLabela[1, 0].Text;
                label6.Text = unosLabela[1, 1].Text;
                label7.Text = unosLabela[1, 2].Text;
                label8.Text = unosLabela[1, 3].Text;

                label5.Image = unosLabela[1, 0].Image;
                label6.Image = unosLabela[1, 1].Image;
                label7.Image = unosLabela[1, 2].Image;
                label8.Image = unosLabela[1, 3].Image;
            }
            if (kolona == 2)
            {
                label9.Text = unosLabela[2, 0].Text;
                label10.Text = unosLabela[2, 1].Text;
                label11.Text = unosLabela[2, 2].Text;
                label12.Text = unosLabela[2, 3].Text;

                label9.Image = unosLabela[2, 0].Image;
                label10.Image = unosLabela[2, 1].Image;
                label11.Image = unosLabela[2, 2].Image;
                label12.Image = unosLabela[2, 3].Image;
            }
            if (kolona == 3)
            {
                label13.Text = unosLabela[3, 0].Text;
                label14.Text = unosLabela[3, 1].Text;
                label15.Text = unosLabela[3, 2].Text;
                label16.Text = unosLabela[3, 3].Text;

                label13.Image = unosLabela[3, 0].Image;
                label14.Image = unosLabela[3, 1].Image;
                label15.Image = unosLabela[3, 2].Image;
                label16.Image = unosLabela[3, 3].Image;
            }
            if (kolona == 4)
            {
                label17.Text = unosLabela[4, 0].Text;
                label18.Text = unosLabela[4, 1].Text;
                label19.Text = unosLabela[4, 2].Text;
                label20.Text = unosLabela[4, 3].Text;

                label17.Image = unosLabela[4, 0].Image;
                label18.Image = unosLabela[4, 1].Image;
                label19.Image = unosLabela[4, 2].Image;
                label20.Image = unosLabela[4, 3].Image;
            }
            if (kolona == 5)
            {
                label21.Text = unosLabela[5, 0].Text;
                label22.Text = unosLabela[5, 1].Text;
                label23.Text = unosLabela[5, 2].Text;
                label24.Text = unosLabela[5, 3].Text;

                label21.Image = unosLabela[5, 0].Image;
                label22.Image = unosLabela[5, 1].Image;
                label23.Image = unosLabela[5, 2].Image;
                label24.Image = unosLabela[5, 3].Image;
            }
        }

        void bojaLabela_Color(int kolona, int red)
        {
            if (kolona == 0)
            {
                label25.BackColor = bojaLabela[0, 0].BackColor;
                label26.BackColor = bojaLabela[0, 1].BackColor;
                label27.BackColor = bojaLabela[0, 2].BackColor;
                label28.BackColor = bojaLabela[0, 3].BackColor;
            }
            if (kolona == 1)
            {
                label29.BackColor = bojaLabela[1, 0].BackColor;
                label30.BackColor = bojaLabela[1, 1].BackColor;
                label31.BackColor = bojaLabela[1, 2].BackColor;
                label32.BackColor = bojaLabela[1, 3].BackColor;
            }
            if (kolona == 2)
            {
                label33.BackColor = bojaLabela[2, 0].BackColor;
                label34.BackColor = bojaLabela[2, 1].BackColor;
                label35.BackColor = bojaLabela[2, 2].BackColor;
                label36.BackColor = bojaLabela[2, 3].BackColor;
            }
            if (kolona == 3)
            {
                label37.BackColor = bojaLabela[3, 0].BackColor;
                label38.BackColor = bojaLabela[3, 1].BackColor;
                label39.BackColor = bojaLabela[3, 2].BackColor;
                label40.BackColor = bojaLabela[3, 3].BackColor;
            }
            if (kolona == 4)
            {
                label41.BackColor = bojaLabela[4, 0].BackColor;
                label42.BackColor = bojaLabela[4, 1].BackColor;
                label43.BackColor = bojaLabela[4, 2].BackColor;
                label44.BackColor = bojaLabela[4, 3].BackColor;
            }
            if (kolona == 5)
            {
                label45.BackColor = bojaLabela[5, 0].BackColor;
                label46.BackColor = bojaLabela[5, 1].BackColor;
                label47.BackColor = bojaLabela[5, 2].BackColor;
                label48.BackColor = bojaLabela[5, 3].BackColor;
            }
        }

        void ispisi()
        {
            f1.Text = kombinacijaString[0];
            f2.Text = kombinacijaString[1];
            f3.Text = kombinacijaString[2];
            f4.Text = kombinacijaString[3];
        }

        void kraj(int kolona, int red) {
            if (kolona == 6 && red == 0)
            {
                Thread.Sleep(500);
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                b4.Enabled = false;
                b5.Enabled = false;
                b6.Enabled = false;

                ispisi();
            }
        }

        void crvenih(int kolona, ref int crvenihPolja)
        {
            for (int vRed = 0; vRed < 4; vRed++)
                if (kombinacijaString.Contains((unosLabela[kolona, vRed].Text)))
                    if (kombinacijaString[vRed] == unosLabela[kolona, vRed].Text)
                        crvenihPolja++;
            
        }

        void pogodjenih(int kolona, ref int pogodjenihPolja, string[] proveraString)
        {
            Array.Copy(kombinacijaString, proveraString, 4);
            
            for (int vRed = 0; vRed < 4; vRed++)
                if (proveraString.Contains((unosLabela[kolona, vRed].Text)))
                {
                    string ukloni = unosLabela[kolona, vRed].Text;
                    int ukloniIdx = Array.IndexOf(proveraString, ukloni);

                    proveraString[ukloniIdx] = "0";
                    
                    pogodjenihPolja++;
                }
        }

        void provera(int kolona, int red)
        {
            int pogodjenihPolja = 0;
            int crvenihPolja = 0;

            crvenih(kolona, ref crvenihPolja);
            pogodjenih(kolona, ref pogodjenihPolja, proveraString);

            for (int vRed = 0; vRed < crvenihPolja; vRed++) 
            {
                bojaLabela[kolona, vRed].BackColor = Color.Red;
                bojaLabela_Color(kolona, vRed);
            }
            
            for (int vRed = crvenihPolja; vRed < pogodjenihPolja; vRed++)
            {
                bojaLabela[kolona, vRed].BackColor = Color.Yellow;
                bojaLabela_Color(kolona, vRed);
            }
            
            /**//**//**//**/

            if (crvenihPolja == 4)
            {
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                b4.Enabled = false;
                b5.Enabled = false;
                b6.Enabled = false;

                ispisi();
            }
        }

        void unos(ref int kolona, ref int red, string text)
        {
            unosLabela[kolona, red].Text = text;
            unosLabela_Znak(kolona, red);
            red++;
            if (red == 4)
            {
                provera(kolona, red);
                kolona++;
                red = 0;
                kraj(kolona, red);
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            unos(ref kolona,ref red, "1");
        }

        private void b2_Click(object sender, EventArgs e)
        {
            unos(ref kolona, ref red, "2");
        }

        private void b3_Click(object sender, EventArgs e)
        {
            unos(ref kolona, ref red, "3");
        }

        private void b4_Click(object sender, EventArgs e)
        {
            unos(ref kolona, ref red, "4");
        }

        private void b5_Click(object sender, EventArgs e)
        {
            unos(ref kolona, ref red, "5");
        }

        private void b6_Click(object sender, EventArgs e)
        {
            unos(ref kolona, ref red, "6");
        }

        private void timeT_Tick(object sender, EventArgs e)
        {
            vreme--;
            labelT.Text = vreme.ToString()+"s";
            if (vreme == 0)
            {
                ispisi();
                timeT.Enabled = false;
            }
        }

        private void skockoF_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void novaIgraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 6;i++) {
                for (int j = 0; j < 4; j++) {
                    unosLabela[i, j].Text = "";
                    bojaLabela[i, j].BackColor = Color.LightSkyBlue;
                    unosLabela_Znak(i, j);
                    bojaLabela_Color(i, j);
                }
            }
            f1.Text = "";
            f2.Text = "";
            f3.Text = "";
            f4.Text = "";

            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            b4.Enabled = true;
            b5.Enabled = true;
            b6.Enabled = true;

            kolona = 0;
            red = 0;

            gen(out kombinacijaInt);
            genS(out kombinacijaString);

            vreme = 120;
            timeT.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Meni meni = new Meni();
            this.Close();
            meni.Show();
            
        }

    }
}
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
    public partial class Meni : Form
    {
        
        public Meni()
        {
            InitializeComponent();
            button1.Hide();
        }

        private void ioB_Click(object sender, EventArgs e)
        {
            iksoksF iksoks = new iksoksF();
            iksoks.Show();
            this.Hide();
        }

        private void sB_Click(object sender, EventArgs e)
        {
            skockoF skocko = new skockoF();
            skocko.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = false;
            base.OnFormClosing(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Meni_Load(object sender, EventArgs e)
        {

        }

        
    }
}

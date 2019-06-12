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
    public partial class sudokuF : Form
    {
        public TextBox[,] T = new TextBox[9, 9];

        public int[,] sudoku = new int[9, 9];
        
        public int[,] b1 = new int[3, 3];
        public int[,] b2 = new int[3, 3];
        public int[,] b3 = new int[3, 3];

        public int[,] b4 = new int[3, 3];
        public int[,] b5 = new int[3, 3];
        public int[,] b6 = new int[3, 3];

        public int[,] b7 = new int[3, 3];
        public int[,] b8 = new int[3, 3];
        public int[,] b9 = new int[3, 3];


        public sudokuF()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = false;
            base.OnFormClosing(e);
        }

        private void sudokuF_Load(object sender, EventArgs e)
        {

        }

        

        

        

        
        

        

       

        
 

        

        
    }
}

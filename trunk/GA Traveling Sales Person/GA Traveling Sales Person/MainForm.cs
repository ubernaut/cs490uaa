using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GA_Traveling_Sales_Person
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 1337;
            TSPGraph myTSP = new TSPGraph(3, i);
            TSPGraph myTPS2 = new TSPGraph(3, i);

            
        }

    }
}
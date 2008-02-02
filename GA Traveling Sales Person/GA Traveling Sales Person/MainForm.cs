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
        private int popSize = 0;
        private int generationCount = 0;
        private int randomSeed = 0;

        public MainForm()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 1337;
            TSPGraph myTSP = new TSPGraph(3, i);
            TSPGraph myTPS2 = new TSPGraph(3, i);



            textBox1.Text = "This is my cool box yo";




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
        
                popSize = Int32.Parse(textBox1.Text);
            
                Console.Out.WriteLine(e);
            

        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            generationCount = Int32.Parse(textBox2.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void textBox4_Validated(object sender, EventArgs e)
        {
            randomSeed = Int32.Parse(textBox4.Text);
        }

        private void textBox3_Validated(object sender, EventArgs e)
        {

        }

        private void button1_Validated(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //instantiate GA and set in motion


        }

    }
}

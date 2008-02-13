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
        private int maxGen = 0;
        private int randomSeed = 0;
        private int townCount = 0;
        private double probCrossOver = 0;
        private double probMutate = 0;
        private double probReproduce = 0;


        public MainForm()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            bestFitnessLabel.Text = "";
            bestTourLabel.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            try
            {
                popSize = Int32.Parse(textBoxPopSize.Text);

                Console.Out.WriteLine(e);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex);
            }

        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            maxGen = Int32.Parse(textBoxMaxGen.Text);
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
            randomSeed = Int32.Parse(textBoxRandSeed.Text);
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
            
            ParseVariables();
            GA myGa = new GA(maxGen, popSize, randomSeed, townCount, probCrossOver, probMutate, probReproduce);
            myGa.Run();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrossOverTests test = new CrossOverTests();
            test.Show();
        }

        /// <summary>
        /// Pulls the numbers out of the text boxes and sets the 
        /// class variables
        /// </summary>
        private void ParseVariables()
        {
            popSize = Int32.Parse(textBoxPopSize.Text);
            maxGen = Int32.Parse(textBoxMaxGen.Text);
            randomSeed = Int32.Parse(textBoxRandSeed.Text);
            townCount = Int32.Parse(textBoxTownCount.Text);

            probCrossOver = Double.Parse(textBoxProbCO.Text);
            probMutate = Double.Parse(textBoxProbMut.Text);
            probReproduce = Double.Parse(textBoxProbRep.Text);

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EvoStrat
{
    public partial class Tests : Form
    {
        Random rand = new Random();


        List<Individual> parentList;
        Individual child;


        public Tests()
        {
            InitializeComponent();
        }

        private void Tests_Load(object sender, EventArgs e)
        {
            parentList = new List<Individual>();
            int mu = 3;
            for (int i = 0; i < mu; i++)
            {
                Individual temp = new Individual();
                temp.X.Add((rand.NextDouble() * 15) - 3);
                temp.X.Add((rand.NextDouble() * 2) + 4);
                temp.Sigma.Add(rand.NextDouble());
                temp.Sigma.Add(rand.NextDouble());

                parentList.Add(temp);
            }

            label1.Text = "Parent1: " + parentList[0].ToString();
            label2.Text = "Parent2: " + parentList[1].ToString();
            label3.Text = "Parent3: " + parentList[2].ToString();

        }



        private void button2_Click(object sender, EventArgs e)
        {
            ES myEs = new ES();

            child = myEs.Recombination(parentList);
            label4.Text = child.ToString(); ;
        }
    }
}
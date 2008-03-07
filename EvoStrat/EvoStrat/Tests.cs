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
                Individual temp = new Individual(rand.Next(), 1);
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
            ES myEs = new ES(3,21,1,20000,2);
            myEs.RunOneGen();
            child = myEs.Recombination(parentList);
            label4.Text = child.ToString(); ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ES myES = new ES();
            double maxValue = -1; 
            double x1=-999;
            double total= double.MinValue;


            for (double i = -3; i <= 12; i += .0001)
            {
                double checkValue = i * Math.Sin(4 * Math.PI * i); 
                if (checkValue > maxValue)
                {
                    maxValue = checkValue;
                    x1 = i;
                }
            }

            label5.Text = "x1: " + x1.ToString();
            label6.Text = Math.Round(maxValue,2).ToString();
            total =maxValue;

            double x2 = -999;
            maxValue = -1; 
            for (double i = 4; i <= 6; i += .0001)
            {
                double checkValue = i * Math.Sin(20 * Math.PI * i);
                if (checkValue > maxValue)
                {
                    maxValue = checkValue;
                    x2 = i;
                }
            }

            label7.Text = "x2: " + x2.ToString();
            label8.Text = Math.Round(maxValue, 2).ToString();


            total += maxValue + 21.5;
            label9.Text = total.ToString();

        }
    }
}
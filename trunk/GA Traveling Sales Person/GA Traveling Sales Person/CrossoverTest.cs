using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GA_Traveling_Sales_Person
{
    public partial class CrossoverTest : Form
    {
        public CrossoverTest()
        {
            InitializeComponent();
        }
        Tour father;
        Tour mother;
        Tour child;
        int coStart;
        int coEnd;

        private void TestForm_Load(object sender, EventArgs e)
        {
            father = new Tour(9);
            father.Route = StringToRoute(textBox2.Text);

            mother = new Tour(9);
            mother.Route = StringToRoute(textBox3.Text);

            child = new Tour();
            coStart = (int)numericUpDown1.Value;
            coEnd = (int)numericUpDown2.Value;

        }

        //randomize
        private void button1_Click(object sender, EventArgs e)
        {
            father = new Tour(9);
            textBox2.Text = RouteToString(father.Route);

            mother = new Tour(9);
            textBox3.Text = RouteToString(mother.Route);

            Random rand = new Random();

            numericUpDown1.Value = rand.Next(1, 8);
            numericUpDown2.Value = rand.Next((int)numericUpDown1.Value, 9);


        }


        //do crossover
        private void button2_Click(object sender, EventArgs e)
        {
            CrossOver co = new CrossOver();

            child = co.PMX1Child(father, mother, coStart, coEnd);

            textBox4.Text = RouteToString(child.Route);

        }






        private string RouteToString(int[] route)
        {
            string temp = "";
            for (int i = 0; i < route.Length; i++)
            {
                temp += route[i].ToString();
            }

            return temp;
        }

        private int[] StringToRoute(string route)
        {
            int[] temp = new int[route.Length];
            for (int i = 0; i < route.Length; i++)
            {
                temp[i] = Int32.Parse(route.Substring(i, 1));
            }

            return temp;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value >= numericUpDown2.Value)
            {
                numericUpDown1.Value = numericUpDown2.Value - 1;
            }
            coStart = (int)numericUpDown1.Value;

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value <= numericUpDown1.Value)
            {
                numericUpDown2.Value = numericUpDown1.Value + 1;
            }
            coEnd = (int)numericUpDown2.Value;
        }


    }
}
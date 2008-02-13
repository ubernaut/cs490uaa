using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GA_Traveling_Sales_Person
{
    public partial class CrossOverTests : Form
    {
        Random rand;
        int length = 9;
        Tour father;
        Tour mother;
        TSPGraph graph;


        public CrossOverTests()
        {
            InitializeComponent();


        }
        private void CrossOverTests_Load(object sender, EventArgs e)
        {
            rand = new Random();
            father = GetFather();
            mother = GetMother();

            graph = new TSPGraph(length, rand.Next());

        }


        private void randButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

            for (int i = 1; i < length + 1; i++)
            {
                textBox1.Text += i.ToString();
                textBox2.Text += i.ToString();
            }
            father = GetFather();
            mother = GetMother();

            for (int i = 0; i < length; i++)
            {
                int temp;
                int swapLoc;

                swapLoc = rand.Next(0, length);
                temp = father.Route[i];
                father.Route[i] = father.Route[swapLoc];
                father.Route[swapLoc] = temp;

                swapLoc = rand.Next(0, length);
                temp = mother.Route[i];
                mother.Route[i] = mother.Route[swapLoc];
                mother.Route[swapLoc] = temp;


            }

            //set father and mother text boxes
            textBox1.Text = "";
            textBox2.Text = "";
            for (int i = 0; i < length; i++)
            {

                textBox1.Text += father.Route[i].ToString();
                textBox2.Text += mother.Route[i].ToString();
            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {

            Tour childA = new Tour(); 
            Tour childB = new Tour(); 


            if (comboBox1.SelectedItem.Equals("Partially Mapped"))
            {
                PMCrossOver pmx = new PMCrossOver(graph);
                childA = pmx.CrossOver1Child(father, mother,(int)numericUpDown1.Value,(int)numericUpDown2.Value);
                childB = pmx.CrossOver1Child(mother, father,(int)numericUpDown1.Value,(int)numericUpDown2.Value);
            }
            else if (comboBox1.SelectedItem.Equals("Cycle"))
            {
                CycleCrossOver cx = new CycleCrossOver(graph);
                childA = cx.CrossOver1Child(father, mother);
                childB = cx.CrossOver1Child(mother, father);
            }
            else if (comboBox1.SelectedItem.Equals("Order"))
            {
                OrderCX ox = new OrderCX(graph);
                childA = ox.OrderCrossEm(father, mother);
                childB = ox.OrderCrossEm(mother, father);
            }
            else
            {
                Console.Out.WriteLine("Error! bad cross over op");
            }


            textBox3.Text = "";
            textBox4.Text = "";

            for (int i = 0; i < length; i++)
            {

                textBox3.Text += childA.Route[i].ToString();
                textBox4.Text += childB.Route[i].ToString();
            }


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }


        private Tour GetFather()
        {
            Tour father = new Tour();

            int[] temp = new int[length];

            string genes = textBox1.Text;
            for (int i = 0; i < length; i++)
            {
                temp[i] = Int32.Parse(genes.Substring(i, 1));
            }
            father.Route = temp;
            return father;
        }

        private Tour GetMother()
        {
            Tour mother = new Tour();

            int[] temp = new int[length];

            string genes = textBox2.Text;
            for (int i = 0; i < length; i++)
            {
                temp[i] = Int32.Parse(genes.Substring(i, 1));
            }
            mother.Route = temp;
            return mother;
        }



    }
}
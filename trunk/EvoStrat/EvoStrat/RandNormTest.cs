using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CenterSpace.Free;

namespace EvoStrat
{
    public partial class RandNormTest : Form
    {
        Random rand = new Random();

        //Reference:http://www.centerspace.net/resources.php
        Histo histogram;
        NormalDist normal;


        public RandNormTest()
        {
            InitializeComponent();
        }

        private void RandNormTest_Load(object sender, EventArgs e)
        {
            histogram = new Histo(30, -4, 4);
            normal = new NormalDist(0, Math.Sqrt(1));
        }




        private double RandNormal(double mean, double sigma)
        {
            double result;
            double randNum = rand.NextDouble();
            result = mean + (sigma * (Math.Sqrt(-2 * Math.Log(randNum)) * Math.Cos(6.28 * randNum)));
            return result;
        }

        /// <summary>
        /// Normaly distribued Random Number generator
        /// Uses the Box Muller transformation
        /// Reference:http://williamandrus.tripod.com/NormalDistRN.html
        /// </summary>
        /// <returns></returns>
        private double RandNorm()
        {
            double x1,x2;
            double w;
            double y1,y2;
            do{
                x1 = 2.0 * rand.NextDouble() - 1.0;
                x2 = 2.0 * rand.NextDouble() - 1.0;
                w = x1 * x1 + x2 * x2; 
            }while(w>=1.0);

            w = Math.Sqrt((-2.0 * Math.Log(w)) / w);
            y1 = x1 * w;
            y2 = x2 * w;
            return y1;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            histogram.Reset();
            int count = Int32.Parse(textBox2.Text);
            for (int i = 0; i < count; i++)
            {
                //double num = RandNormal(0, 1);
                //histogram.AddData(num);

                histogram.AddData(RandNorm());
                label1.Text = histogram.StemLeaf();

                Application.DoEvents();
            }

        }


    }
}
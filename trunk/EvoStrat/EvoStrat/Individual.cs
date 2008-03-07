using System;
using System.Collections.Generic;
using System.Text;

namespace EvoStrat
{
    class Individual
    {
        double x1Min = -3;
        double x1Max =12;
        double x2Min = 4;
        double x2Max = 6;

        List<double> x;

        public List<double> X
        {
            get { return x; }
            set { x = value; }
        }

        List<double> sigma;

        public List<double> Sigma
        {
            get { return sigma; }
            set { sigma = value; }
        }


        double fitness;

        public double Fitness
        {
            get { return fitness; }
            set { fitness = value; }
        }

        public Individual()
        {
            x = new List<double>();
            sigma = new List<double>();
        }
        /// <summary>
        /// Creates a new random Individual
        /// within the constraints and with the specified initial sigma values;
        /// </summary>
        public Individual(int randSeed, double sigmaInit)
        {
            Random rand = new Random(randSeed);
            x = new List<double>();
            sigma = new List<double>();

            x.Add((rand.NextDouble() * 15) - 3);
            x.Add((rand.NextDouble() * 2) + 4);
            sigma.Add(sigmaInit);
            sigma.Add(sigmaInit);

        }
        public Individual(List<double> xIn, List<double> sigmaIn)
        {
            x = xIn;
            sigma = sigmaIn;
        }




        public override string ToString()
        {

            string text = "";
            text = "X{" + x[0];
            for(int i=1; i<x.Count; i++){
                text += ","+x[i];
            }

            text += "} Sigma{" + sigma[0];
            for (int i = 1; i < sigma.Count; i++)
            {
                text += "," +sigma[i];
            }
            text += "}";
            return text;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EvoStrat
{
    class Individual : IComparable<Individual>
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
            int roundDigits = 3;

            string text = "Fit:" + Math.Round(fitness,roundDigits);
            text += " X{" + Math.Round(x[0],roundDigits);
            for(int i=1; i<x.Count; i++){
                text += "," + Math.Round(x[i], roundDigits);
            }

            text += "} Sigma{" + Math.Round(sigma[0],roundDigits);
            for (int i = 1; i < sigma.Count; i++)
            {
                text += "," + Math.Round(sigma[i], roundDigits);
            }
            text += "}";
            return text;
        }


        #region IComparable<Individual> Members

        public int CompareTo(Individual other)
        {
            int order;
            if (this.Fitness > other.Fitness)
            {
                order = -1;
            }
            else if (this.Fitness == other.Fitness)
            {
                order = 0;
            }
            else if (this.Fitness < other.Fitness)
            {
                order = 1;
            }
            else
            {
                throw new Exception("Individual CompareTo() error!");
            }

            return order;
        }

        #endregion
    }
}

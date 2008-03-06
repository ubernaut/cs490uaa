using System;
using System.Collections.Generic;
using System.Text;

namespace EvoStrat
{
    class ES
    {
        private int mu;
        private int lamda;
        private double sigmaInit;
        private int termCount;
        private int n;

        int currentGen;

        #region Properties
        public int Mu
        {
            get { return mu; }
            set { mu = value; }
        }

        public int Lamda
        {
            get { return lamda; }
            set { lamda = value; }
        }

        public double SigmaInit
        {
            get { return sigmaInit; }
            set { sigmaInit = value; }
        }

        public int TermCount
        {
            get { return termCount; }
            set { termCount = value; }
        }

        public double Tau
        {
            get { return tau; }
            set { tau = value; }
        }

        public double TauPrime
        {
            get { return tauPrime; }
            set { tauPrime = value; }
        }
        public int N
        {
            get { return n; }
            set { n = value; }
        }

        public int CurrentGen
        {
            get { return currentGen; }
            set { currentGen = value; }
        }

        #endregion


        private double tau;
        private double tauPrime;

        Random rand = new Random();
        public ES()
        {
            throw new Exception("Temp constructor, to be removed");
        }

        public ES(int muIn, int lamdaIn, double sigmaInitIn, int termCountIn, int dimentionsIn)
        {
            //set properties
            mu = muIn;
            lamda = lamdaIn;
            sigmaInit = sigmaInitIn;
            termCount = termCountIn;
            n = dimentionsIn;

            //calculate the taus
            tau = 1 / Math.Sqrt(2 * n);
            tauPrime = 1 / Math.Sqrt(2 * Math.Sqrt(n));

        }







        internal void RunOneGen()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// Discrete Global Recombination
        /// </summary>
        /// <param name="parentA"></param>
        /// <param name="parentB"></param>
        /// <returns></returns>
        public Individual Recombination(List<Individual> parentList)
        {
            int numOfGenes = parentList[0].X.Count;
            Individual child = new Individual();

            Individual parentA;
            Individual parentB;
            for (int i = 0; i < numOfGenes; i++)
            {
                //select new parents for each gene
                int indexA = rand.Next(0, parentList.Count);
                parentA = parentList[indexA];

                int indexB = indexA;
                //keep getting random numbers until indexA != indexB
                while (indexA == indexB)
                {
                    indexB = rand.Next(0, parentList.Count);
                }
                parentB = parentList[indexB];


                if (rand.Next(0, 2) == 0)
                {
                    child.X[i] = parentA.X[i];
                }
                else
                {
                    child.X[i] = parentB.X[i];
                }
            }


            //TODO:
            //where do the sigmas come from?


            return child;
        }

        public Individual Mutation(Individual indivIn)
        {
            Individual newIndiv = new Individual();

            //for each gene
            //double overallLearningRate = tauPrime * N(0, 1);

            for (int i = 0; i < indivIn.X.Count; i++)
            {
                //calculate the new sigma
                //double coordinateLearningRate = tau * N(0,1);
                //newSigma = sigma * exp(tauPrime * N(0,1) + tau * Ni(0,1))

                    //if newSigma < minSigma
                        //newSigma = minSigma



                //calculate the new X based on new sigma
                //newX = x + N(0,newSigma)


            }



            return newIndiv;
        }

        /// <summary>
        /// Normaly distribued Random Number generator
        /// Uses the Box Muller transformation
        /// Reference:http://williamandrus.tripod.com/NormalDistRN.html
        /// </summary>
        /// <returns></returns>
        private double RandNorm()
        {
            double x1, x2;
            double w;
            double y1, y2;
            do
            {
                x1 = 2.0 * rand.NextDouble() - 1.0;
                x2 = 2.0 * rand.NextDouble() - 1.0;
                w = x1 * x1 + x2 * x2;
            } while (w >= 1.0);

            w = Math.Sqrt((-2.0 * Math.Log(w)) / w);
            y1 = x1 * w;
            y2 = x2 * w;
            //generates 2 rand numbers, but we only want to return one
            return y1;
        }

    }
}

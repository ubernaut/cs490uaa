using System;
using System.Collections.Generic;
using System.Text;

namespace EvoStrat
{
    class ES
    {
        private int mu;
        private int lambda;
        private double sigmaInit;
        private int termCount;
        private int n;
        private double minSigma = 0.0001;
        int currentGen;

        #region Properties
        public int Mu
        {
            get { return mu; }
            set { mu = value; }
        }

        public int Lambda
        {
            get { return lambda; }
            set { lambda = value; }
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

        private List<Individual> parentList;
        private List<Individual> childList;

        Random rand = new Random();
        public ES()
        {
           // throw new Exception("Temp constructor, to be removed");
        }

        public ES(int muIn, int lambdaIn, double sigmaInitIn, int termCountIn, int dimentionsIn)
        {
            //set properties
            mu = muIn;
            lambda = lambdaIn;
            sigmaInit = sigmaInitIn;
            termCount = termCountIn;
            n = dimentionsIn;

            //calculate the taus
            tau = 1 / Math.Sqrt(2 * n);
            tauPrime = 1 / Math.Sqrt(2 * Math.Sqrt(n));

            childList = new List<Individual>();

            //create the initial lambda individuals
            for (int i = 0; i < lambda; i++)
            {
                childList.Add(new Individual(rand.Next(),sigmaInit) );
            }

        }

        /// <summary>
        /// 
        /// </summary>
        public void RunOneGen()
        {
            //select the mu parents  for this generation

            //calc fitness on all the children
            for (int i = 0; i < childList.Count; i++)
            {
                SetFitness(childList[i]);
            }
            childList.Sort();
            
            parentList = new List<Individual>();
            for (int i = 0; i < mu; i++)
            {
                parentList.Add(childList[i]);
            }
            



            //do recombination to create lambda new individuals
            childList.Clear();
            for (int i = 0; i < lambda; i++)
            {
                childList.Add(Recombination(parentList));
            }


            //mutate all of the individuals
            for (int i = 0; i < childList.Count; i++)
            {
                childList[i] = Mutation(childList[i]);
            }

            childList.Sort();

            
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

            //set the X values
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
                    child.X.Add(parentA.X[i]);
                }
                else
                {
                    child.X.Add(parentB.X[i]);
                }
            }

            //Set the sigma values
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

                child.Sigma.Add((parentA.Sigma[i] + parentB.Sigma[i]) / 2.0);
            }


            return child;
        }

        public Individual Mutation(Individual indivIn)
        {
            Individual newIndiv = new Individual();

            //for each gene
            double overallLearningRate = tauPrime * RandNorm();

            //if newSigma < minSigma
            //newSigma = minSigma

            for (int i = 0; i < indivIn.X.Count; i++)
            { //newSigma = sigma * exp(tauPrime * N(0,1) + tau * Ni(0,1))

                //calculate the new sigma
                
                double coordinateLearningRate = Tau * RandNorm();
                indivIn.Sigma[i] = indivIn.Sigma[i] * Math.Exp(overallLearningRate + coordinateLearningRate);
                //calculate the new X based on new sigma
                if (minSigma > indivIn.Sigma[i]) indivIn.Sigma[i] = minSigma;

                //newX = x + N(0,newSigma)

                double xHolder = indivIn.X[i];

                indivIn.X[i] = indivIn.X[i] + indivIn.Sigma[i] * RandNorm();
                
                //if()
                if (i == 0) while (-3 > indivIn.X[0] || indivIn.X[0] > 12)
                    indivIn.X[0] = xHolder + indivIn.Sigma[0] * RandNorm();

                if (i == 1) while (4 > indivIn.X[1] || indivIn.X[1] > 6)
                    indivIn.X[1] = xHolder + indivIn.Sigma[1] * RandNorm(); 
            }
            
            return indivIn;
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


        /// <summary>
        /// Calculates and sets the fitness value for the individual
        /// </summary>
        /// <param name="indiv"></param>
        private void SetFitness(Individual indiv)
        {
            double x1 = indiv.X[0];
            double x2 = indiv.X[1];

            double fit;
            fit = 21.5;
            fit += x1 * Math.Sin(4 * Math.PI * x1);
            fit += x2 * Math.Sin(20 * Math.PI * x2);

            indiv.Fitness = fit;
        }


    }
}

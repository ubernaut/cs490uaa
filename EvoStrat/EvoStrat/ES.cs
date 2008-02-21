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
            tau = 1/Math.Sqrt(2*n);
            tauPrime = 1 / Math.Sqrt(2 * Math.Sqrt(n));

        }







        internal void RunOneGen()
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}

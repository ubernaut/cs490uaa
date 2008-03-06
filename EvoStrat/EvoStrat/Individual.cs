using System;
using System.Collections.Generic;
using System.Text;

namespace EvoStrat
{
    class Individual
    {
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




        public Individual()
        {
        }




        public override string ToString()
        {

            throw new Exception("Individual.ToString() not yet imlemented");

            //string text = "";
            //return text;
        }

    }
}

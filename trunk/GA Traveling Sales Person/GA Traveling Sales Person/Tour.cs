using System;
using System.Collections.Generic;
using System.Text;

namespace GA_Traveling_Sales_Person
{
    class Tour
    {
        int cost;

        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        int[] route;

        public int[] Route
        {
            get { return route; }
            set { route = value; }
        }

        /// <summary>
        /// Create a random tour of cityNum cities
        /// </summary>
        /// <param name="cityNum">number of cities in the tour</param>
        public Tour(int cityNum)
        {
            Random rand = new Random();
            //since we will always be starting and ending at city 0
            //we only need (cityNum-1) nodes in the route
            route = new int[cityNum-1];
            
            //initialize the route with all the cities in order
            for (int i = 0; i < cityNum-1; i++)
            {
                route[i] = rand.Next(1, cityNum + 1);
            }

            //randomize the route
            for (int i = 0; i < cityNum; i++)
            {
                int swapNum = rand.Next(1, cityNum + 1);
                int temp = route[i];
                route[i] = route[swapNum];
                route[swapNum] = temp;
            }

        }


        public Tour()
        {
        }

        /// <summary>
        /// Calculates and stores the total cost of this Tour based on the 
        /// TSPGraph specified
        /// </summary>
        /// <param name="graph">The TSPGraph to base the fitness on</param>
        /// <returns></returns>
        public void CalcFitness(TSPGraph graph)
        {
            //TODO
            //fitness is calculated starting and ending at city 0

            cost = Int32.MaxValue;
  
            
        }
    }
}

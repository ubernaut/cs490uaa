using System;
using System.Collections.Generic;
using System.Text;

namespace GA_Traveling_Sales_Person
{
    class Tour
    {
        
        Random rand = new Random();

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
            

            route = new int[cityNum];
            
            //initialize the route with all the cities in order
            for (int i = 0; i < cityNum; i++)
            {
                route[i] = rand.Next(1, cityNum+1);
            }

            //randomize the route
            for (int i = 0; i < cityNum; i++)
            {
                int swapNum = rand.Next(0, cityNum);
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

            int fitness = 0;

            //for each city in the tour
            for (int i = 0; i < route.Length-2; i++)
            {

                //add up the cost from i to i+1
                fitness += graph.GetCost(route[i], route[i + 1]);


            }

            //add the cost to go from the last city to the first
            fitness += graph.GetCost(route[route.Length - 1], route[0]);



            cost = fitness;
        }
    }
}

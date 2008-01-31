using System;
using System.Collections.Generic;
using System.Text;

namespace GA_Traveling_Sales_Person
{
    /// <summary>
    /// Represents a NxN fully connected graph where each index
    /// is the cost to fly from one city to another
    /// </summary>
    class TSPGraph
    {
        int cityCount;
        int[,] node;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="cityCount">how many cities in the graph</param>
        /// <param name="randSeed">the random seed value</param>
        public TSPGraph(int cityCountIn, int randSeed)
        {
            cityCount = cityCountIn;
            node = new int[cityCount, cityCount];

            Random rand = new Random(randSeed);

            for (int y = 0; y < cityCount; y++)
            {
                for (int x = 0; x < cityCount; x++)
                {
                    node[x, y] = rand.Next(99, 2001);
                }
            }

        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GA_Traveling_Sales_Person
{
    /// <summary>
    /// Cycle CrossOver class
    /// </summary>
    class CycleCrossOver
    {
 
        TSPGraph graph;

        public CycleCrossOver(TSPGraph graphIn)
        {
            graph = graphIn;
        }


        /// <summary>
        /// Cycle Cross over of two parents
        /// </summary>
        /// <param name="father">Father Tour</param>
        /// <param name="mother">Mother Tour</param>
        /// <returns>A list of two child Tours</returns>
        public List<Tour> CrossOver2Child(Tour father, Tour mother)
        {
            Tour childA = CrossOver1Child(father, mother);
            Tour childB = CrossOver1Child(mother, father);
            List<Tour> childList = new List<Tour>();

            childList.Add(childA);
            childList.Add(childB);
            return childList;

        }

        /// <summary>
        /// Cycle Cross over of two parents 
        /// </summary>
        /// <param name="father">Father Tour</param>
        /// <param name="mother">Mother Tour</param>
        /// <returns>A single child Tour</returns>
        public Tour CrossOver1Child(Tour father, Tour mother)
        {
            //initialize the new child's route to all -1's
            Tour child = new Tour();
            int[] temp = new int[father.Route.Length];
            for (int i = 0; i < father.Route.Length; i++)
            {
                temp[i] = -1;
            }
            child.Route = temp;


            int loc = 0;
            int mothersGeneAtLoc;

            //while there are still 'empty' spots
            while (Array.IndexOf(child.Route, -1) > -1)
            {
                //put the fathers gene in the child
                child.Route[loc] = father.Route[loc];

                //get the mothers gene at this locations
                mothersGeneAtLoc = mother.Route[loc];

                //if the mothers gene isn't in the child yet
                if (Array.IndexOf(child.Route, mothersGeneAtLoc) == -1)
                {
                    //find the location in the father of the mothers gene
                    loc = Array.IndexOf(father.Route, mothersGeneAtLoc);
                }
                else
                {
                    //swap the mother and the father
                    Tour swapTemp = father;
                    father = mother;
                    mother = swapTemp;

                    //find the next empty spot in the child
                    loc = Array.IndexOf(child.Route, -1);
                }
            }

            child.CalcFitness(graph);

            return child;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GA_Traveling_Sales_Person
{
    /// <summary>
    /// Partially Mapped CrossOver class
    /// </summary>
    class PMCrossOver
    {
        Random rand = new Random();
        TSPGraph graph;

        public PMCrossOver(TSPGraph graphIn)
        {
            graph = graphIn;
        }

        


        /// <summary>
        /// Partially Mapped CrossOver Function
        /// </summary>
        /// <param name="father"></param>
        /// <param name="mother"></param>
        /// <returns>Returns 2 children Tours in a List<Tour></returns>
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
        /// Partially Mapped CrossOver Function with random crossover points
        /// </summary>
        /// <param name="father"></param>
        /// <param name="mother"></param>
        /// <returns></returns>
        public Tour CrossOver1Child(Tour father, Tour mother)
        {
            //randomly choose cross over section
            int coStart = rand.Next(1, father.Route.Length - 1);        //Cross over start point, can be from index 1 to (n-2)
            int coEnd = rand.Next(coStart + 1, father.Route.Length);    //Cross over end point, can be from (start+1) to (n-1)

            return PMX1Child(father, mother, coStart, coEnd);
        }

        /// <summary>
        /// Partially Mapped CrossOver Function with specified crossover points
        /// </summary>
        /// <param name="father"></param>
        /// <param name="mother"></param>
        /// <param name="coStartIn"></param>
        /// <param name="coEndIn"></param>
        /// <returns></returns>
        public Tour PMX1Child(Tour father, Tour mother, int coStartIn, int coEndIn)
        {
            //create a child
            Tour child = new Tour(father.Route.Length);
            //initialize the child to have a route of all -1
            for (int i = 0; i < child.Route.Length; i++)
            {
                child.Route[i] = -1;
            }

            //set crossover points
            int coStart = coStartIn;
            int coEnd = coEndIn;

            //copy the cross over section from the father to the child
            for (int i = coStart; i <= coEnd; i++)
            {
                child.Route[i] = father.Route[i];
            }



            //for each gene in the cross over section
            for (int i = coStart; i <= coEnd; i++)
            {
                //if the mothers gene is not in the child yet
                if (Array.IndexOf(child.Route, mother.Route[i]) == -1)
                {
                    int locInMother = i;
                    bool done = false;
                    while (!done)
                    {
                        //get the value of the corresponding gene in the father
                        int fathersGene = father.Route[locInMother];

                        //find the location in the mother of the fathers gene
                        locInMother = Array.IndexOf(mother.Route, fathersGene);

                        //if that location in the child is empty
                        if (child.Route[locInMother] == -1)
                        {
                            //fill it with the mothers gene
                            child.Route[locInMother] = mother.Route[i];
                            //go on to next mother gene
                            done = true;
                        }
                        //else, we will start the cycle again by checking the fathers gene
                    }


                }
                //else go to the next mother gene


            }

            //for each child gene not yet filled
            for (int i = 0; i < child.Route.Length; i++)
            {
                //copy from mother to child
                if (child.Route[i] == -1)
                {
                    child.Route[i] = mother.Route[i];
                }
            }



            child.CalcFitness(graph);

            return child;
        }




    }
}

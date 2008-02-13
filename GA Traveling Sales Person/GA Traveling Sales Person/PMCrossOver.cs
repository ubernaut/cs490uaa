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

            return CrossOver1Child(father, mother, coStart, coEnd);
        }

        /// <summary>
        /// Partially Mapped CrossOver Function with specified crossover points
        /// </summary>
        /// <param name="father"></param>
        /// <param name="mother"></param>
        /// <param name="coStartIn">inclusive</param>
        /// <param name="coEndIn">inclusive</param>
        /// <returns></returns>
        public Tour CrossOver1Child(Tour father, Tour mother, int coStartIn, int coEndIn)
        {
            //create a child
            Tour child = new Tour(father.Route.Length);

            //copy father to child
            //child.Route = father.Route; //bad bad!! Routes are objects!
            father.Route.CopyTo(child.Route,0);

            //copy cross over section of mother to child
            for (int i = coStartIn; i <= coEndIn; i++)
            {
                child.Route[i] = mother.Route[i];
            }

            //until we make a full pass and find no duplicates
            bool duplicateFound = true;
            while (duplicateFound)
            {
                duplicateFound = false;

                //for each gene in cross over section of child
                for (int i = coStartIn; i <= coEndIn; i++)
                {

                    int loc;
                    //if the gene exist in the part before the crossover
                    loc = IndexOfBefore(child.Route[i], child.Route, coStartIn);
                    if (loc > -1)
                    {
                        //replace the gene after the cross over
                        //with the gene in the father that is at the location of the gene in the mother
                        int geneLoc = Array.IndexOf(mother.Route, child.Route[i]);
                        int fatherGene = father.Route[geneLoc];
                        child.Route[loc] = fatherGene;
                        duplicateFound = true;

                    }



                    //if the gene exist in the part after the crossover
                    loc = IndexOfAfter(child.Route[i], child.Route, coEndIn);
                    if (loc > -1)
                    {
                        //replace the gene after the cross over
                        //with the gene in the father that is at the location of the gene in the mother
                        int geneLoc = Array.IndexOf(mother.Route, child.Route[i]);
                        int fatherGene = father.Route[geneLoc];
                        child.Route[loc] = fatherGene;
                        duplicateFound = true;

                    }




                }
            }


            child.CalcFitness(graph);

            return child;
        }

        /// <summary>
        /// returns the first index of gene, that exists before the crossover point
        /// </summary>
        /// <param name="gene"></param>
        /// <param name="route"></param>
        /// <param name="coStart">cross over start</param>
        /// <returns></returns>
        private int IndexOfBefore(int gene, int[] route, int coStart)
        {
            int loc = -1;


            bool found = false;
            int i = 0;
            while (!found && i < coStart)
            {
                if (route[i] == gene)
                {
                    found = true;
                    loc = i;
                }

                i++;
            }


            return loc;
        }

        /// <summary>
        /// returns the first index of gene, that exists after the crossover point
        /// </summary>
        /// <param name="gene"></param>
        /// <param name="route"></param>
        /// <param name="coEnd">cross over end</param>
        /// <returns></returns>
        private int IndexOfAfter(int gene, int[] route, int coEnd)
        {
            int loc = -1;


            bool found = false;
            int i = coEnd + 1;
            while (!found && i < route.Length)
            {
                if (route[i] == gene)
                {
                    found = true;
                    loc = i;
                }

                i++;
            }


            return loc;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GA_Traveling_Sales_Person
{
    class GA
    {
        /// <summary>
        ///Setup the Genetic Algrithm with the required parameters 
        /// </summary>
        /// <param name="maxGeneration"></param>
        /// <param name="populationSize"></param>
        /// <param name="randSeed"></param>
        /// <param name="cityCount"></param>
        /// 
        private List<Tour> population = new Tour();
        private Tour bestOfRun= new Tour();
        private TSPGraph lookUp = new TSPGraph();
        private int popSize = 0;
        private int cityCount = 0;
        private int maxGens = 0;
        private int seed = 0;
        private float currGenFit = 0;
        private float sumFit = 0;
        private List<float> genFit;

        public GA(int maxGeneration, int populationSize, int randSeed, int townCount)
        {
            lookUp = new TSPGraph(cityCount, randSeed);
            maxGens = maxGeneration;
            popSize = populationSize;
            seed = randSeed;
            cityCount = townCount;

            for (int i = 0; i < populationSize; i++)
            {
                population.Add(new Tour(cityCount));
            }
            EvalPopulation();


        }

        public void EvalPopulation() 
        {
            sumFit = 0;
            foreach (Tour individual in population) 
            {

                individual.CalcFitness(lookUp);
                sumFit += individual.Cost;
                if (individual.Cost < bestOfRun.Cost) bestOfRun = individual;
                   
            }
            currGenFit = sumFit / popSize;
            genFit.Add(currGenFit);
        }

        public Tour Run() {

            for (int i = 0; i < maxGens; i++)
            {
                //select individuals for crossover

                //select individuals for mutation          

                EvalPopulation();
            }

            return bestOfRun;
        }

        public void Selection() 
        { 
            List<Tour> nextGen = new List<Tour>;
            
            
            foreach(Tour aRoute in population)
            {
               float routeChance = aRoute.Cost / currGenFit;
            }

        }

    }
}

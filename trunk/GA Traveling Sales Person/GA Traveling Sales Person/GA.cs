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
        private List<Tour> population = new List<Tour>();
        private Tour bestOfRun = new Tour();
        private TSPGraph graph;
        private int popSize;
        private int cityCount;
        private int maxGens;
        private int seed;
        private double probCrossOver;
        private double probMutate;
        private double probReproduce;
        private const int NUMBER_OF_RUNS = 3;


        private Tour[] pmxBestOfRun;
        private Tour[] cxBestOfRun;
        private Tour[] oxBestOfRun;



        public GA(int maxGeneration, int populationSize, int randSeed, int townCount, double probCO, double probMut, double probRep)
        {
            maxGens = maxGeneration;
            popSize = populationSize;
            seed = randSeed;
            cityCount = townCount;

            probCrossOver = probCO;
            probMutate = probMut;
            probReproduce = probRep;



            pmxBestOfRun = new Tour[NUMBER_OF_RUNS];
            cxBestOfRun = new Tour[NUMBER_OF_RUNS];
            oxBestOfRun = new Tour[NUMBER_OF_RUNS];

            graph = new TSPGraph(cityCount, seed);

        }

        /// <summary>
        /// Runs all the Cross over operations 3 times
        /// and records best Tour of run for each
        /// </summary>
        /// 
        public void Run()
        {
            for (int i = 0; i < NUMBER_OF_RUNS; i++)
            {
                pmxBestOfRun[i] = RunPMX();
                //oxBestOfRun[i] = RunOX();
                cxBestOfRun[i] = RunCX();
            }

        }



        private Tour RunPMX()
        {
            Tour bestOfGeneration;
            Random rand = new Random();

            //sample population
            List<Tour> population = new List<Tour>();

            //initialize to random individuals
            //and calculate their fitness
            for (int i = 0; i < popSize; i++)
            {
                Tour temp = new Tour(cityCount);
                temp.CalcFitness(graph);
                population.Add(temp);
            }




            //for each generation
            for (int gen = 0; gen < maxGens; gen++)
            {
                //the next generation
                List<Tour> newPopulation = new List<Tour>();     

                //seperate selection pools
                List<Tour> crossOverPool = new List<Tour>();
                List<Tour> mutatePool = new List<Tour>();
                List<Tour> reproducePool = new List<Tour>();

            }





            return new Tour();
        }

        private Tour RunOX()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        private Tour RunCX()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        private double[] EvalPopulation(List<Tour> generation)
        {

            Tour[] myGeneration=generation.ToArray();
            int popSize = myGeneration.Length;
            double[] genSlice = new double[popSize];
            
            float sumFit = 0;
            foreach (Tour individual in myGeneration)
            {
                individual.CalcFitness(graph);
                sumFit += individual.Cost;
            }
            int genIndex = 0;
            foreach (Tour individual in myGeneration)
            {
                genSlice[genIndex] = individual.Cost/sumFit;
                genIndex += 1;
            }

            return genSlice;              
             
        }



        private void Selection()
        {
            /*
            List<Tour> nextGen = new List<Tour>();
            
            
            foreach(Tour aRoute in population)
            {
               float routeChance = aRoute.Cost / currGenFit;
            }
            */
        }

    }
}

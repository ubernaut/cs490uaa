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
        private Random rand = new Random();

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
                pmxBestOfRun[i] = RunAllGens(0);
                //oxBestOfRun[i] = RunAllGens(1);
                cxBestOfRun[i] = RunAllGens(2);
            }

        }

        private Tour RunAllGens(int coOp)
        {
            Tour bestOfGeneration;
            rand = new Random();

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
            //setup the roulette wheel with percentages of each individual
            double[] slice = EvalPopulation(population);

            //spin the wheel and build the selection pool
            List<Tour> crossOverPool = new List<Tour>();
            List<Tour> mutatePool = new List<Tour>();
            List<Tour> reproducePool = new List<Tour>();
            for (int i = 0; i < popSize; i++)
            {
                int selectIndex = Selection(slice);

                //seperate selection pools
                if (i < Math.Round((popSize * probCrossOver), 0))
                {
                    crossOverPool.Add(population[selectIndex]);
                }
                else if (i < Math.Round((popSize * (probCrossOver + probReproduce)), 0))
                {
                    reproducePool.Add(population[selectIndex]);
                }
                else if (i < Math.Round((popSize * (probCrossOver + probReproduce + probMutate)), 0))
                {
                    mutatePool.Add(population[selectIndex]);
                }
                else
                {
                    throw new Exception("Error selecting the right pool");
                }

            }

            //do the operations and fill the new generation
            List<Tour> newPopulation = new List<Tour>(population.Count);
            crossOverPool =  DoCrossOver(crossOverPool, coOp);
            mutatePool = DoMutate(mutatePool);

            return new Tour();
        }



        private List<Tour> DoCrossOver(List<Tour> crossOverPool, int coOp)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        private List<Tour> DoMutate(List<Tour> mutatePool)
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
            foreach (Tour individual in myGeneration){
                genSlice[genIndex] = individual.Cost/sumFit;
                genIndex += 1;
            }

            return genSlice;              
             
        }
        private int Selection(double[] theSlices)
        {           
            double myPick = rand.NextDouble();
            for (int i = 0; i < theSlices.Length; i++) if(theSlices[i] <= myPick) return i;
            return -1000000;
        }

    }
}

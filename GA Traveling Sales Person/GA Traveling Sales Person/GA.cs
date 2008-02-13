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
                oxBestOfRun[i] = RunAllGens(1);
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

            for (int gen = 0; gen < maxGens; gen++)
            {
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
                crossOverPool = DoCrossOver(crossOverPool, coOp);
                mutatePool = DoMutate(mutatePool);

                //copy each pool to newPopulation
                for (int i = 0; i < crossOverPool.Count; i++)
                {
                    newPopulation.Add(crossOverPool[i]);
                }
                for (int i = 0; i < reproducePool.Count; i++)
                {
                    newPopulation.Add(reproducePool[i]);
                }
                for (int i = 0; i < mutatePool.Count; i++)
                {
                    newPopulation.Add(mutatePool[i]);
                }

                newPopulation.Sort();
                if (newPopulation[0].Cost < bestOfRun.Cost)
                {
                    bestOfRun = newPopulation[0];
                }

                population = newPopulation;

            }

            return bestOfRun;
        }



        private List<Tour> DoCrossOver(List<Tour> crossOverPool, int coOp)
        {
            PMCrossOver thePMX = new PMCrossOver(graph);
            OrderCX theOX = new OrderCX(graph);
            CycleCrossOver theCX = new CycleCrossOver(graph);
            //Mutate theMutate = new Mutate();
            List<Tour> nextGen = new List<Tour>();

            for (int i = 0; i < crossOverPool.Count; i += 2)
            {
                Tour Fadda = crossOverPool[i];
                Tour Mudda = crossOverPool[i + 1];
                
                switch (coOp)
                {
                    case 0:
                        nextGen.Add(thePMX.CrossOver1Child(Fadda, Mudda));
                        nextGen.Add(thePMX.CrossOver1Child(Mudda, Fadda));
                        break;
                    case 1:
                        nextGen.Add(theOX.OrderCrossEm(Fadda, Mudda));
                        nextGen.Add(theOX.OrderCrossEm(Mudda, Fadda));
                        break;
                    case 2:
                        nextGen.Add(theCX.CrossOver1Child(Fadda, Mudda));
                        nextGen.Add(theCX.CrossOver1Child(Mudda, Fadda));
                        break;
                }
            }
            return nextGen(); 
        }

        private List<Tour> DoMutate(List<Tour> mutatePool)
        {
            Mutate mut = new Mutate();

            for (int i = 0; i < mutatePool.Count; i++)
            {
                mutatePool[i] = mut.MutateIt(mutatePool[i]);
            }
            return mutatePool;
        }

        private double[] EvalPopulation(List<Tour> generation)
        {
            Tour[] myGeneration = generation.ToArray();
            int popSize = myGeneration.Length;
            double[] genSlice = new double[popSize];

            float sumFit = 0;
            foreach (Tour individual in myGeneration)
            {
                individual.CalcFitness(graph);
                sumFit += individual.Cost;
            }
            int genIndex = 0;
            double runningSum = 0;
            foreach (Tour individual in myGeneration){
                double indFract = individual.Cost / sumFit;
                runningSum += indFract;
                genSlice[genIndex] = runningSum;
                
                genIndex += 1;
            }

            return genSlice;

        }
        private int Selection(double[] theSlices)
        {
            double myPick = rand.NextDouble();
            int num = -1000000;
            for (int i = 0; i < theSlices.Length; i++)
            {
                if (theSlices[i] <= myPick)
                {
                    num= i;
                }
            }
            return num;
        }

    }
}

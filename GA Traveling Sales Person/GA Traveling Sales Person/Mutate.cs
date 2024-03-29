using System;
using System.Collections.Generic;
using System.Text;

namespace GA_Traveling_Sales_Person
{
    class Mutate
    {
        public Mutate() { }
        public Tour MutateIt(Tour individual)
        {
            Int32 cityCount = individual.Route.Length;
            cityCount -= 1; //prevent out of bound exception
            int[] mutant = individual.Route;
            Random x = new Random();
            Int32 cityA = x.Next(0, cityCount);
            Int32 cityB = x.Next(0, cityCount);
            while (cityA == cityB)cityB = x.Next(0, cityCount);
            Int32 holdCity = mutant[cityA];
            mutant[cityA] = mutant[cityB];
            mutant[cityB] = holdCity;
            individual.Route = mutant;
            return individual;

        }
    }
}

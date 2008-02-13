using System;
using System.Collections.Generic;
using System.Text;
//OrderCX by Collin Schroeder collin.schroeder@gmail.com

namespace GA_Traveling_Sales_Person
{
    class OrderCX
    {

        private TSPGraph myGraph;
        
        public OrderCX(TSPGraph theGraph) 
        {
            myGraph = theGraph;
        }
        public Tour OrderCrossEm(Tour parentA, Tour parentB) 
        {   
            int cityCount = parentA.Route.Length;
            cityCount -= 1; //prevent out of bound exception
            int[] childA = parentA.Route;
            Random x = new Random();
            int cityA = x.Next(0, cityCount);
            int cityB = x.Next(0, cityCount);
            int laterCity = 0;
            int earlyCity = 0;
            while (cityA == cityB)  cityB = x.Next(0, cityCount);
            if (cityA > cityB){
                earlyCity = cityB;
                laterCity = cityA;
            }

            else{
                earlyCity = cityA;
                laterCity = cityB;
            }

            return OrderCrossEm(parentA, parentB, earlyCity, laterCity);
        
        }
        
        public Tour OrderCrossEm(Tour parentA, Tour parentB, int earlyCity, int laterCity)
        {
            int cityCount = parentB.Route.Length;
            int interval = laterCity - earlyCity;
            List<int> citysInInterval = new List<int>();
            List<int> theChildRoute = new List<int>();

            for (int i = earlyCity; i <= laterCity; i++) citysInInterval.Add(parentA.Route[i]);
            
            theChildRoute.AddRange(citysInInterval);
            int trackFront = 0;
            //foreach (int cityInB in parentB.Route)
            for (int i = laterCity+1; i < parentB.Route.Length;i++)
            {
                if (theChildRoute.Contains(parentB.Route[i]));
                else{

                    if (theChildRoute.Count < parentB.Route.Length - earlyCity) theChildRoute.Add(parentB.Route[i]);
                    else {
                        theChildRoute.Insert(trackFront, parentB.Route[i]);
                        trackFront += 1;
                    }
                 }
            }
            for (int i = 0; i <= laterCity; i++)
            {
                if (theChildRoute.Contains(parentB.Route[i]));
                else{

                    if (theChildRoute.Count < parentB.Route.Length - earlyCity) theChildRoute.Add(parentB.Route[i]);
                    else {
                        theChildRoute.Insert(trackFront, parentB.Route[i]);
                        trackFront += 1;
                    }
                 }
            }
            Tour childToReturn = new Tour(parentA.Route.Length);
            childToReturn.Route = theChildRoute.ToArray();
            //parentA.Route.CopyTo(childToReturn.Route, 0);

            //parentA.Route = theChildRoute.ToArray();
            //parentA.CalcFitness(myGraph);
                       
            return childToReturn;
        
        }
    }
}

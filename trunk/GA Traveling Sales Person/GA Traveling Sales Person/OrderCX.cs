using System;
using System.Collections.Generic;
using System.Text;

namespace GA_Traveling_Sales_Person
{
    class OrderCX
    {

        private TSPGraph myGraph;

        public OrderCX(TSPGraph theGraph) 
        {
            myGraph = theGraph;
        }
        public Tour OrderCrossEm(Tour parentA, Tour parentB){
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
            int interval = laterCity - earlyCity;
            List<int> citysInInterval = new List<int>();
            List<int> theChildRoute = new List<int>();

            for (int i = 0; i < interval; i++) citysInInterval.Add(parentA.Route[i + earlyCity]);
            
            theChildRoute.AddRange(citysInInterval);
            int trackFront = 0;
            foreach (int cityInB in parentB.Route)
            {
                   
                    if(theChildRoute.Contains(cityInB));
                    else{
                        //while (theChildRoute.Count() < cityCount){ 
                            
                            if(theChildRoute.Count<(cityCount-earlyCity)){
                                //insert it at the end of the list
                                theChildRoute.Add(cityInB);
                            }
                            else{
                                //insert it at the begining
                                theChildRoute.Insert(trackFront,cityInB);
                            
                            }
                        //}
                    }
                }
            //individual.Route = mutant;
            //individual.CalcFitness(myGraph);
            parentA.Route = theChildRoute.ToArray();
            parentA.CalcFitness(myGraph);
            
            return parentA;
        
        }
    }
}

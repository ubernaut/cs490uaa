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
            Int32 cityCount = parentA.Route.Length;
            
            cityCount -= 1; //prevent out of bound exception
            int[] childA = parentA.Route;
            Random x = new Random();
            Int32 cityA = x.Next(0, cityCount);
            Int32 cityB = x.Next(0, cityCount);
            Int32 laterCity = 0;
            Int32 earlyCity = 0;
            while (cityA == cityB)  cityB = x.Next(0, cityCount);
            if (cityA > cityB){
                earlyCity = cityB;
                laterCity = cityA;
            }

            else{
                earlyCity = cityA;
                laterCity = cityB;
            }
            Int32 interval = laterCity - earlyCity;
            List<Int32> citysInInterval = new List<Int32>();
            List<Int32> theChildRoute = new List<Int32>();

            for (int i = 0; i < interval; i++) citysInInterval.Add(parentA.Route[i + earlyCity]);
            
            theChildRoute.AddRange(citysInInterval);
            Int32 trackFront =0;
            foreach(Int32 cityInB in parentB.Route){
                   
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

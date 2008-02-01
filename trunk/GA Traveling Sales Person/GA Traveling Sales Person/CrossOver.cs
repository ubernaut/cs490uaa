using System;
using System.Collections.Generic;
using System.Text;

namespace GA_Traveling_Sales_Person
{
    /// <summary>
    /// Class that contains all the crossover
    /// functions for the GA
    /// </summary>
    class CrossOver
    {
        public CrossOver()
        {
        }


        /// <summary>
        /// Partially Mapped Crossover Function
        /// </summary>
        /// <param name="father"></param>
        /// <param name="mother"></param>
        /// <returns>Returns 2 children Tours in a List<Tour></returns>
        public List<Tour> PMX(Tour father, Tour mother)
        {
            Tour childA = new Tour();
            Tour childB = new Tour();



            List<Tour> childList = new List<Tour>();
            childList.Add(childA);
            childList.Add(childB);
            return childList;

        }




    }
}

using System;
using System.Collections.Generic;
using System.Text;
using EvoStrat;
using individual;
/// <summary>
/// Summary description for Class1
/// </summary>
public class TestMutation
{
    private ES testES = new ES();
    private List<Individual> myGen = new List<Individual>();
    private Random rand= new Random();
    public TestMutation()
	{
        Console.WriteLine("please input the number of individuals to mutate: ");
        Int32 pplCount = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < pplCount; i++)
        {
            Individual someInd = new Individual();
            someInd.Sigma[0] = 1;
            someInd.Sigma[1] = 1;
            someInd.X[0] = (15 * rand.NextDouble())-3;
            someInd.X[1] = (2 * rand.NextDouble()) +4;
            myGen.Add(someInd);
        }

        for (int i = 0; i < pplCount; i++)
        {
            Console.Out.WriteLine(myGen[i].toString());
            myGen[i]=testES.Mutation(myGen[i]);
            Console.Out.WriteLine(myGen[i].toString());
        }
		//
		// TODO: Add constructor logic here
		//
	}
}

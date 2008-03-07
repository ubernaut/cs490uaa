using System;
using System.Collections.Generic;
using System.Text;
using EvoStrat;
//using Individual;
/// <summary>
/// Summary description for Class1
/// </summary>
public class TestMutation
{
    private ES testES = new ES(3, 21, 1, 20000,2);
    private List<Individual> myGen = new List<Individual>();
    private Random rand= new Random();
    public TestMutation()
	{
        //Console.WriteLine("please input the number of individuals to mutate: ");
        //Int32 pplCount = Int32.Parse(Console.In.ReadLine());
        Int32 pplCount = 10;
        for (int i = 0; i < pplCount; i++)
        {
            Individual someInd = new Individual();
            someInd.Sigma.Add( 1.0);
            someInd.Sigma.Add(1.0);
            someInd.X.Add( (15 * rand.NextDouble())-3);
            someInd.X.Add( (2 * rand.NextDouble()) +4);
            myGen.Add(someInd);
        }

        for (int i = 0; i < pplCount; i++)
        {
            Console.Out.WriteLine("individual"+ i);
            Console.Out.WriteLine("preMutation: ");
            Console.Out.WriteLine(myGen[i].ToString());
            myGen[i]=testES.Mutation(myGen[i]);
            Console.Out.WriteLine("postMutation: ");
            Console.Out.WriteLine(myGen[i].ToString());
            
        }
		//
		// TODO: Add constructor logic here 
		//
	}
}

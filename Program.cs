using System;

namespace Udemyyyyy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age - ");
		    int agge = int.Parse(Console.ReadLine());
		
		
		    if(agge >= 12 && agge <= 55)
		    {
		    	Console.WriteLine("You are good to get a job.");
	    	}
		
		    else
		    {
			    Console.WriteLine("You are either young or old to get a job");
		    }        
        }
    }
}

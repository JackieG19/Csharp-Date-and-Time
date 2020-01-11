using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
		var timeSpan = new TimeSpan(1,2,3);
		
		// Add and Subtract
		Console.WriteLine("Add Example" + timeSpan.Add(TimeSpan.FromMinutes(8)));
		/*The Add() method in C# is used to return a new TimeSpan object whose 
		value is the sum of the specified TimeSpan object and this instance.*/
		
		Console.WriteLine("Subtract Example" + timeSpan.Subtract(TimeSpan.FromMinutes(2)));
		/*This method is used to subtract the specified time or duration from this instance.*/
        }
    }
}

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
		var timeSpan1 = new TimeSpan(1,0,0);
		
		Console.WriteLine(timeSpan);
		Console.WriteLine(timeSpan1);
		/*Initializes a new instance of the TimeSpan structure 
		to a specified number of hours, minutes, and seconds.*/
        }
    }
}

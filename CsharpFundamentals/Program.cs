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
		
		// ToString
		Console.WriteLine("ToString" + timeSpan.ToString());
		//Converts the value of the current TimeSpan object to its equivalent string representation.
        }
    }
}

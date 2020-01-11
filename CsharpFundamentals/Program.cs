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
		
		// Parse
		Console.WriteLine("Parse:" + TimeSpan.Parse("01:02:03"));
		/*Converts the string representation of a time interval to its TimeSpan equivalent.*/
        }
    }
}

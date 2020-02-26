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

		var start = DateTime.Now;
		var end = DateTime.Now.AddMinutes(2);
		/*This method is used to return a new DateTime that adds 
		the specified number of minutes to the value of this instance.*/
		
		var duration = end - start;
		Console.WriteLine("Duration" + duration);
        }
    }
}

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

		var timeSpan2 = TimeSpan.FromHours(1);
		Console.WriteLine(timeSpan2);
		/*This method is used to get a TimeSpan that represents a specified 
		number of hours, accurate to the nearest millisecond.*/
        }
    }
}

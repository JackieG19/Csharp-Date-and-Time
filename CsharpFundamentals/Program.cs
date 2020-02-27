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
		
		// Properties
		Console.WriteLine("Total Minutes" + timeSpan.TotalMinutes);
		/*Getting the value of the current TimeSpan structure expressed in whole and fractional minutes.*/
        }
    }
}

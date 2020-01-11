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
		Console.WriteLine("Minutes" + timeSpan.Minutes);
		/*Getting the minutes component of the time interval 
		represented by the current TimeSpan structure.*/
        }
    }
}

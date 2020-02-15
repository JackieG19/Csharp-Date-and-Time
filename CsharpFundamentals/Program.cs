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
		var dateTime = new DateTime(2015, 1, 1);
		var now = DateTime.Now;
		
		Console.WriteLine("Minutes: " + now.Minute);
		/*Gets the minute component of the date represented by this instance
		The minute component, expressed as a value between 0 and 59.*/
        }
    }
}

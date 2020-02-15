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
		
		var tomorrow = now.AddDays(1);
		Console.Write(tomorrow);
		
		var yesterday = now.AddDays(-1);
		Console.Write(yesterday);
		
		/*This method is used to return a new DateTime that adds or sbubtracts 
		the specified number of days to the value of this instance.*/
        }
    }
}

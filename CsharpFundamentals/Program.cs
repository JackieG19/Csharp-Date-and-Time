﻿using System;
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
		var today = DateTime.Today;
		
		Console.WriteLine(now.ToShortDateString);
		/*This method is used to convert the value of the current DateTime 
		object to its equivalent short date string representation.*/
        }
    }
}

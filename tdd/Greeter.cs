using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd
{
	public class Greeter
	{
		public static String Greeting(String input)
		{
			if(input != String.Empty)
			{
				return "Hello, " + input;
			}
			return "Hello, my friend";
		}
	}
}

using System;

namespace tdd
{
	class Program
	{
		static void Main(string[] args)
		{
			String greeting = Greeter.Greeting("Bob,Thomas,July");
			Console.WriteLine(greeting);
		}
	}
}

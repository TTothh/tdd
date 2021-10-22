using System;

namespace tdd
{
	class Program
	{
		static void Main(string[] args)
		{
			Greeter g = new Greeter();
			String greeting = g.Greeting(" ");
			Console.WriteLine(greeting);
		}
	}
}

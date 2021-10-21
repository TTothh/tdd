using System;

namespace tdd
{
	class Program
	{
		public String TestFunction()
		{
			return "asd";
		}

		static void Main(string[] args)
		{
			String greeting = Greeter.Greeting("asd");
			Console.WriteLine(greeting);
		}
	}
}

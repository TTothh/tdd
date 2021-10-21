using System;
using Xunit;
using tdd;

namespace tdd_tests
{
	public class UnitTest1
	{
		[Fact(DisplayName = "Test Greeter class Greeting function for empty string")]
		public void EmptyInputGreeting()
		{
			String msg = Greeter.Greeting("");

			Assert.Equal("Hello, my friend", msg);
		}

		[Fact(DisplayName = "Test Greeting for single input")]
		public void SingleInputGreeting()
		{
			String input = "Bob";
			String greeting = Greeter.Greeting(input);

			Assert.Equal("Hello, Bob", greeting);
		}
	}
}

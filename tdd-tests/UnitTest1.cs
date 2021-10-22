using System;
using Xunit;
using tdd;

namespace tdd_tests
{
	public class UnitTest1
	{
		Greeter g = new Greeter();

		[Fact(DisplayName = "Test Greeter class Greeting function for empty string")]
		public void EmptyInputGreeting()
		{
			String msg = g.Greeting("");

			Assert.Equal("Hello, my friend", msg);
		}

		[Fact(DisplayName = "Test Greeting for single input")]
		public void SingleInputGreeting()
		{
			String input = "Bob";
			String greeting = g.Greeting(input);

			Assert.Equal("Hello, Bob", greeting);
		}

		[Fact(DisplayName = "Test for multiple inputs")]
		public void MultipleInputGreeting()
		{
			String input = "Bob,Thomas,July";
			String greeting = g.Greeting(input);

			Assert.Equal("Hello, Bob, Thomas and July", greeting);
		}

		[Fact(DisplayName = "Test InputSplitter for different inputs")]
		public void SplitterTestForEmptyInput()
		{
			String input1 = g.Greeting(",");
			String input2 = g.Greeting(" , ");
			String input3 = g.Greeting(", ");
			String input4 = g.Greeting(" ,");
			String input5 = g.Greeting(" ");

			Assert.Equal("Hello, my friend", input1);
			Assert.Equal("Hello, my friend", input2);
			Assert.Equal("Hello, my friend", input3);
			Assert.Equal("Hello, my friend", input4);
			Assert.Equal("Hello, my friend", input5);
		}
	}
}

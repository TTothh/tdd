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
			String msg1 = g.Greeting("");
			String msg2 = g.Greeting(",");
			String msg3 = g.Greeting(" , ");
			String msg4 = g.Greeting(", ");
			String msg5 = g.Greeting(" ,");

			Assert.Equal("Hello, my friend", msg1);
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

			Assert.Empty(input1);
			Assert.Empty(input2);
			Assert.Empty(input3);
			Assert.Empty(input4);
		}
	}
}

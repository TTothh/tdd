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
			string input = "";
			string greeting = g.Greeting(input);

			Assert.Equal("Hello, my friend", greeting);
		}

		[Fact(DisplayName = "Test Greeting for single input")]
		public void SingleInputGreeting()
		{
			string input = "Bob";
			string greeting = g.Greeting(input);

			Assert.Equal("Hello, Bob", greeting);
		}

		[Fact(DisplayName = "Test for multiple inputs")]
		public void MultipleInputGreeting()
		{
			string input = "Bob,Thomas,July";
			string greeting = g.Greeting(input);

			Assert.Equal("Hello, Bob, Thomas and July", greeting);
		}

		[Fact(DisplayName = "Test for all capital greeting when single input")]
		public void AllcapitalGreetingSingleInput()
		{
			string input = "BOB";
			string greeting = g.Greeting(input);

			Assert.Equal("HELLO BOB!", greeting);
		}

		[Fact(DisplayName = "Test for mixed case capital inputs")]
		public void MixedCaseGreetingMultipleInput()
		{
			string input = "JAY,Maya,Alice,BOB,Charlotte";
			string greeting = g.Greeting(input);

			Assert.Equal("Hello, Maya, Alice and Charlotte. AND HELLO JAY AND BOB!", greeting);
		}

		[Fact(DisplayName = "Test InputSplitter for different inputs")]
		public void SplitterTestForEmptyInput()
		{
			string greeting1 = g.Greeting(",");
			string greeting2 = g.Greeting(" , ");
			string greeting3 = g.Greeting(", ");
			string greeting4 = g.Greeting(" ,");
			string greeting5 = g.Greeting(" ");

			Assert.Equal("Hello, my friend", greeting1);
			Assert.Equal("Hello, my friend", greeting2);
			Assert.Equal("Hello, my friend", greeting3);
			Assert.Equal("Hello, my friend", greeting4);
			Assert.Equal("Hello, my friend", greeting5);
		}
	}
}

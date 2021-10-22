using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace tdd
{
	public class Greeter
	{

		public string Greeting(string input)
		{
			string[] names = InputSplitter(input);

			StringBuilder sb = new();
			sb.Append(InputHandler(names));

			return sb.ToString();
		}

		public string[] InputSplitter(string names)
		{
			List<string> output = new List<string>();

			if(names.Equals(string.Empty) || names.ContainsOnly(' '))
			{
				return output.ToArray();
			}

			if (!names.Equals(string.Empty) && !names.Contains(','))
			{
				output.Add(names);
			}

			if(names.Contains(','))
			{
				output = names.Split(',').ToList();

				for(int i = 0; i < output.Count; i++) {
					output[i].Trim();

					if (output[i].Equals(string.Empty) || output[i].ContainsOnly(' '))
					{
						output.Remove(output[i]);
						i -= 1;
					}
				}
			}

			return output.ToArray();
		}

		public string InputHandler(string[] names)
		{
			return names.Length switch
			{
				0 => EmptyInputPrinter(),
				1 => SingleInputPrinter(names),
				_ => MultipleInputHandler(names),
			};
		}

		private string EmptyInputPrinter()
		{
			return "Hello, my friend";
		}

		private string SingleInputPrinter(string[] names)
		{
			string output = "";

			if (names[0].isCapital())
			{
				output = "HELLO " + names[0].ToUpper() + "!";
			}
			else
			{
				output = "Hello, " + names[0];
			}

			return output;
		}

		private string MultipleInputHandler(string[] names)
		{
			string output = "";

			bool mixed = false;

			foreach (string name in names)
			{
				if(name.isCapital())
				{
					mixed = true;
				}
			}

			if(!mixed)
			{
				output = LowercaseInputPrinter(names);
			}
			else
			{
				output = MixedInputPrinter(names);
			}

			return output;
		}

		private string LowercaseInputPrinter(string[] names)
		{
			StringBuilder output = new();

			for (int i = 0; i < names.Length; i++)
			{
				if (i == names.Length - 1)
				{
					output.Append(" and " + names[i]);
					continue;
				}
				else if (i == names.Length - 2)
				{
					output.Append(names[i]);
				}
				else
				{
					output.Append(names[i] + ", ");
				}
			}

			return "Hello, " + output.ToString();
		}

		private string MixedInputPrinter(string[] names)
		{
			StringBuilder output = new();

			List<string> capital = new();
			List<string> lower = new();

			foreach (string name in names)
			{
				if(name.isCapital())
				{
					capital.Add(name);
				}
				else
				{
					lower.Add(name);
				}
			}

			output.Append("Hello, ")
				  .Append(LowerCaseGreetingBuilder(lower))
				  .Append(". AND HELLO ")
				  .Append(CapitalCaseGreetingBuilder(capital))
				  .Append('!');
			
			return output.ToString();
		}

		private string LowerCaseGreetingBuilder(List<string> names)
		{
			StringBuilder output = new();

			for (int i = 0; i < names.Count; i++)
			{
				if (i == names.Count - 1)
				{
					output.Append(" and " + names[i]);
					continue;
				}
				else if (i == names.Count - 2)
				{
					output.Append(names[i]);
				}
				else
				{
					output.Append(names[i] + ", ");
				}
			}

			return output.ToString();
		}

		private string CapitalCaseGreetingBuilder(List<string> names)
		{
			StringBuilder output = new();

			for (int i = 0; i < names.Count; i++)
			{
				if (i == names.Count - 1)
				{
					output.Append(" and " + names[i]);
					continue;
				}
				else if (i == names.Count - 2)
				{
					output.Append(names[i]);
				}
				else
				{
					output.Append(names[i] + ", ");
				}
			}

			return output.ToString().ToUpper();
		}
	}
}

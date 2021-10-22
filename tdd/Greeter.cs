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
			sb.Append("Hello, ");
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
				0 => EmptyInputPrinter(names),
				1 => SingleInputPrinter(names),
				_ => MultipleInputPrinter(names),
			};
		}

		private string EmptyInputPrinter(string[] names)
		{
			return "my friend";
		}

		private string SingleInputPrinter(string[] names)
		{
			return names[0];
		}

		private string MultipleInputPrinter(string[] names)
		{
			StringBuilder output = new();

			for (int i = 0; i < names.Length; i++)
			{
				if (i == names.Length - 1)
				{
					output.Append(" and " + names[i]);
					continue;
				}
				else if(i == names.Length -2)
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
	}
}

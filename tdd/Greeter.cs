using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd
{
	public class Greeter
	{
		public string Greeting(string input)
		{
			string[] names = InputSplitter(input);

			StringBuilder sb = new StringBuilder();
			sb.Append("Hello, ");
			sb.Append(InputHandler(names));

				for (int i = 0; i < names.Length; i++)
				{
					if (i == names.Length - 1)
					{
						sb.Append("and " + names[i]);
						continue;
					}

					sb.Append(names[i] + ", ");
				}

				return sb.ToString();

			return "Hello, my friend";
		}

		public string[] InputSplitter(string names)
		{
			List<string> output = new List<string>();

			if (names.Equals(String.Empty) || !names.Contains(','))
			{
				return output.ToArray();
			}

			if(names.Contains(','))
			{
				output = names.Split(',').ToList();

				foreach (string name in output)
				{
					name.Trim();

					if(name.Equals(string.Empty)) {
						output.Remove(name);
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
			return " my friend";
		}

		private string SingleInputPrinter(string[] names)
		{
			return " " + names[0];
		}

		private string MultipleInputPrinter(string[] names)
		{

			return "asd";
		}
	}
}

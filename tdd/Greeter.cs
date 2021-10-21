using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd
{
	public class Greeter
	{
		public static String Greeting(String input)
		{
			bool singleinput = input.Contains(',');

			if(singleinput)
			{
				return "Hello, " + input;
			}
			else
			{
				String[] names = input.Split(',');

				StringBuilder sb = new StringBuilder();

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
			}

			return "Hello, my friend";
		}
	}
}

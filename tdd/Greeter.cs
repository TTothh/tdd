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

		//Felép a bemeneti stringből egy tömböt amivel könnyeben lehet dolgozni
		public string[] InputSplitter(string names)
		{
			List<string> output = new List<string>();

			//Ha üres vagy csak szóközöket tartalmazó az input akkor üres tömbbel visszatérünk
			if(names.Equals(string.Empty) || names.ContainsOnly(' '))
			{
				return output.ToArray();
			}

			//ne üres de nincs benne ',' akkor single input van
			if (!names.Equals(string.Empty) && !names.Contains(',') && !names.ContainsOnly(' '))
			{
				output.Add(names);
			}

			if(names.Contains(','))
			{
				output = names.Split(',').ToList();

				//Kiveszem az output-ból az üres/nem szabályos elemeket.
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

		//A kapott tömb hossza alapján eldől hogy hogyan lesz feldolgozva az input
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
			
			//Az input összetétele alapján felépítem az output-ot.
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


		//Ha nincs kapitalizált név az inputban akkor ez a function építi föl az inputot
		private string LowercaseInputPrinter(string[] names)
		{
			StringBuilder output = new();

			for (int i = 0; i < names.Length; i++)
			{
				//utolsó elem előtt 'and'
				if (i == names.Length - 1)
				{
					output.Append(" and " + names[i]);
					continue;
				}

				//ez megspórolható lett volna ha tudnék olvasni. 'and' előtt is van ',' csak nem vettem észre...
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


		//Ha van kapitalizált név, akkor ez a függvény kezeli a kirítást
		private string MixedInputPrinter(string[] names)
		{
			StringBuilder output = new();

			List<string> capital = new();
			List<string> lower = new();

			foreach (string name in names)
			{
				if (name.isCapital())
				{
					capital.Add(name);
				}
				else
				{
					lower.Add(name);
				}
			}

			//normál és kapitlás rész felépítése
			string LowerCasePart = GreetingPartBuilder(lower);
			string CapitalCasePart = GreetingPartBuilder(capital).ToUpper();

			output.Append("Hello, ")
				  .Append(LowerCasePart)
				  .Append(". AND HELLO ")
				  .Append(CapitalCasePart)
				  .Append('!');
			
			return output.ToString();
		}

		//üzenetrész felépítése rész felépítése
		private string GreetingPartBuilder(List<string> names)
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
	}
}

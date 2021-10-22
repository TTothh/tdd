using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd
{
	public static class ExtensionMethods
	{

		//Ellenőrzi hogy a string csak egy karakterből áll-e.
		public static bool ContainsOnly(this string str, char singular)
		{
			bool containsonly = true;

			foreach (char character in str)
			{
				if(character != singular)
				{
					containsonly = false;
				}
			}

			return containsonly;
		}

		//Ellenrőzi hogy az adott string csak nagybetűkből áll-e.
		public static bool isCapital(this string str)
		{
			bool isUpper = true;

			foreach (char character in str)
			{
				if(Char.IsLetter(character) && Char.IsLower(character))
				{
					isUpper = false;
				}
			}

			return isUpper;
		}
	}
}

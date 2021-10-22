using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd
{
	public static class ExtensionMethods
	{
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
	}
}

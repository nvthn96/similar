using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Similar.Utility
{
	public class RegexUtility
	{
		public static string Apply(Regex pattern, string str, string replace)
		{
			var input = str;
			while(pattern.IsMatch(input))
			{
				input = pattern.Replace(input, replace);
			}
			return input;
		}
	}
}

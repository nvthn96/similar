using System.Text.RegularExpressions;

namespace Similar.Config.Constant
{
	public class NumberPattern
	{
		public static readonly Regex NumberSpace = new Regex(@"(\d)(\s+)(\d)");
	}

	public class WordPattern
	{
		public static readonly Regex ValidCharacters = new Regex(@"([\w\s]+)");
		public static readonly Regex NonvalidCharacters = new Regex(@"([^\w\s]+)");
		public static readonly Regex WordsPair = new Regex(@"\b(?<word1>([a-zA-Z0-9]+[^\t]?)+)(\t(?<word2>\d+))?\b");
		public static readonly Regex MultipleSpaces = new Regex(@"(\s+)");
	}
}

using Similar.Model.Word;
using System.Text;
using CNumberPattern = Similar.Config.Constant.NumberPattern;

namespace Similar.Utility
{
	public class NumberUtility
	{
		public static string ReduceSentence(string sentence)
		{
			var strBuilder = new StringBuilder(sentence);

			WordLibrary.Month.Apply(strBuilder);
			WordLibrary.Date.Apply(strBuilder);
			WordLibrary.Day.Apply(strBuilder);
			WordLibrary.Number.Apply(strBuilder);

			var result = strBuilder.ToString();
			result = RegexUtility.Apply(CNumberPattern.NumberSpace, result, "$1$3");
			result = Config.Constant.WordPattern.MultipleSpaces.Replace(result, " ");
			result = result.Trim();

			return result;
		}
	}
}

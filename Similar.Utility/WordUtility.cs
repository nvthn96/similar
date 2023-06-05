using Similar.Model.Option;
using Similar.Model.Word;

namespace Similar.Utility
{
	public class WordUtility
	{
		public static string ReduceSentence(string sentence, ReduceOption option)
		{
			var input = sentence;

			if (option.SpecialCharacters) input = Config.Constant.WordPattern.NonvalidCharacters.Replace(input, " ");
			if (option.Number) input = NumberUtility.ReduceSentence(input);
			if (option.Form) input = string.Join(" ", Stemmer.Stem(input));
			if (option.Others.Noun) input = WordLibrary.Noun.Apply(input);
			if (option.Others.Verb) input = WordLibrary.Verb.Apply(input);
			if (option.Others.Adjective) input = WordLibrary.Adjective.Apply(input);
			if (option.Others.Adverb) input = WordLibrary.Adverb.Apply(input);
			if (option.Others.Pronoun) input = WordLibrary.Pronoun.Apply(input);
			if (option.Others.Preposition) input = WordLibrary.Preposition.Apply(input);
			if (option.Others.Conjunction) input = WordLibrary.Conjunction.Apply(input);
			if (option.Others.Interjection) input = WordLibrary.Interjection.Apply(input);

			input = Config.Constant.WordPattern.MultipleSpaces.Replace(input, " ");
			input = input.Trim();

			return input;
		}

		public static string ReduceSentence(string sentence)
		{
			var option = new ReduceOption();
			return ReduceSentence(sentence, option);
		}
	}
}

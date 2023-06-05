using CWord = Similar.Config.Constant.WordLibrary;

namespace Similar.Model.Word
{
	public class WordLibrary
	{
		public static readonly WordClass Adjective = new WordClass(CWord.Adjective.Name, CWord.Adjective.FileName);
		public static readonly WordClass Adverb = new WordClass(CWord.Adverb.Name, CWord.Adverb.FileName);
		public static readonly WordClass Conjunction = new WordClass(CWord.Conjunction.Name, CWord.Conjunction.FileName);
		public static readonly WordClass Date = new WordClass(CWord.Date.Name, CWord.Date.FileName);
		public static readonly WordClass Day = new WordClass(CWord.Day.Name, CWord.Day.FileName);
		public static readonly WordClass Interjection = new WordClass(CWord.Interjection.Name, CWord.Interjection.FileName);
		public static readonly WordClass Month = new WordClass(CWord.Month.Name, CWord.Month.FileName);
		public static readonly WordClass Noun = new WordClass(CWord.Noun.Name, CWord.Noun.FileName);
		public static readonly WordClass Number = new WordClass(CWord.Number.Name, CWord.Number.FileName);
		public static readonly WordClass Preposition = new WordClass(CWord.Preposition.Name, CWord.Preposition.FileName);
		public static readonly WordClass Pronoun = new WordClass(CWord.Pronoun.Name, CWord.Pronoun.FileName);
		public static readonly WordClass Verb = new WordClass(CWord.Verb.Name, CWord.Verb.FileName);
	}
}

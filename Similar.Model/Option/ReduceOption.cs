using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Similar.Model.Option
{
	public class ReduceOption
	{
		public bool SpecialCharacters { get; set; } = true;
		public bool Number { get; set; } = true;
		public bool Form { get; set; } = true;
		public ReduceClasses Others { get; set; } = new ReduceClasses();
	}

	public class ReduceClasses
	{
		public bool Noun { get; set; } = false;
		public bool Verb { get; set; } = false;
		public bool Adjective { get; set; } = false;
		public bool Adverb { get; set; } = false;
		public bool Pronoun { get; set; } = true;
		public bool Preposition { get; set; } = true;
		public bool Conjunction { get; set; } = true;
		public bool Interjection { get; set; } = true;
	}
}

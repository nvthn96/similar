using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CWordPattern = Similar.Config.Constant.WordPattern;

namespace Similar.Model.Word
{
	public class WordClass
	{
		public string Name { get; set; }
		public string FileName { get; set; }
		public Dictionary<string, string> Words { get; set; }
		public IOrderedEnumerable<string> SortedKey { get; set; }

		public WordClass(string name, string fileName)
		{
			Name = name;
			FileName = fileName;
			Words = new Dictionary<string, string>();

			LoadWords();
		}

		private void LoadWords()
		{
			var folder = Path.Combine(Environment.CurrentDirectory, Config.Constant.Folder.Words);
			var file = Path.Combine(folder, FileName);
			var content = File.ReadAllLines(file);
			var keys = new List<string>();
			foreach (var line in content)
			{
				if (CWordPattern.WordsPair.IsMatch(line))
				{
					var matches = CWordPattern.WordsPair.Match(line);
					var word1 = matches.Groups["word1"].Value;
					var word2 = matches.Groups["word2"].Value;

					if (!Words.ContainsKey(word1))
					{
						Words.Add(word1, word2);
						keys.Add(word1);
					}
				}
			}

			// sort keys by length from longer to shorter
			SortedKey = keys.OrderByDescending(key => key.Length);
		}

		public void Apply(Action<string, string> Invoker)
		{
			foreach(var key in SortedKey)
			{
				Invoker.Invoke(key, Words[key]);
			}
		}

		public void Apply(StringBuilder strBuilder)
		{
			foreach (var key in SortedKey)
			{
				strBuilder.Replace(" " + key + " ", " " + Words[key] + " ");
			}
		}

		public string Apply(string str)
		{
			var strBuilder = new StringBuilder(str);
			Apply(strBuilder);
			return strBuilder.ToString();
		}
	}
}

using Similar.Model.Option;
using Similar.Model.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Similar.Utility
{
	public class SimilarUtility
	{
		public static SimilarOutput GetSimilar(string sentence1, string sentence2)
		{
			var item1 = AnalystSentence(sentence1);
			var item2 = AnalystSentence(sentence2);

			var same = item1.DistinctWords.Intersect(item2.DistinctWords);
			var sameCount = same.Count();

			item1.SamePercent = sameCount * 1.0f / item1.DistinctCount;
			item2.SamePercent = sameCount * 1.0f / item2.DistinctCount;

			var output = new SimilarOutput()
			{
				Item1 = item1,
				Item2 = item2,
				SameCount = sameCount
			};

			return output;
		}

		public static SimilarOutput.ItemOutput AnalystSentence(string sentence)
		{
			var option = new ReduceOption();
			var reduce = WordUtility.ReduceSentence(sentence, option);
			var list = reduce.Split(' ').Distinct();
			var listCount = list.Count();
			return new SimilarOutput.ItemOutput()
			{
				Original = sentence,
				Reduced = reduce,
				DistinctWords = list,
				DistinctCount = listCount,
			};
		}
	}
}

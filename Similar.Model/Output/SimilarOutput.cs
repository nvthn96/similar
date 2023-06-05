using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Similar.Model.Output
{
	public class SimilarOutput
	{
		public ItemOutput Item1 { get; set; }
		public ItemOutput Item2 { get; set; }

		public int SameCount { get; set; }

		public class ItemOutput
		{
			public string Original { get; set; }
			public string Reduced { get; set; }
			public IEnumerable<string> DistinctWords { get; set; }
			public int DistinctCount { get; set; }
			public float SamePercent { get; set; }
		}
	}
}

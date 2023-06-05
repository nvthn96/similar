using Similar.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Similar.Test.Utility
{
	[TestClass]
	public class TestNumberSpace
	{
		[TestMethod]
		public void Merge_two_number_one_space()
		{
			var input = "123 456";
			var result = NumberUtility.ReduceSentence(input);

			var output = "123456";

			Assert.AreEqual(output, result);
		}

		[TestMethod]
		public void Merge_two_number_multiple_space()
		{
			var input = "123        456";
			var result = NumberUtility.ReduceSentence(input);

			var output = "123456";

			Assert.AreEqual(output, result);
		}

		[TestMethod]
		public void Merge_two_number_extra_space()
		{
			var input = "    123        456    ";
			var result = NumberUtility.ReduceSentence(input);

			var output = "123456";

			Assert.AreEqual(output, result);
		}
	}
}

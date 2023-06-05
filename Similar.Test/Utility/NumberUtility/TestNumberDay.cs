using Similar.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Similar.Test.Utility
{
	[TestClass]
	public class TestNumberDay
	{
		[TestMethod]
		public void Day_the_twenty_eighth()
		{
			var input = " the twenty eighth ";
			var result = NumberUtility.ReduceSentence(input);

			var output = "28";

			Assert.AreEqual(output, result);
		}

		[TestMethod]
		public void Day_22nd()
		{
			var input = " 22nd ";
			var result = NumberUtility.ReduceSentence(input);

			var output = "22";

			Assert.AreEqual(output, result);
		}

		[TestMethod]
		public void Day_month()
		{
			var input = " 22nd october ";
			var result = NumberUtility.ReduceSentence(input);

			var output = "2210";

			Assert.AreEqual(output, result);
		}
	}
}

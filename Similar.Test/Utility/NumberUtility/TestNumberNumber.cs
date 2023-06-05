using Similar.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Similar.Test.Utility
{
	[TestClass]
	public class TestNumberNumber
	{
		[TestMethod]
		public void Number_0()
		{
			var input = " ab zero ";
			var result = NumberUtility.ReduceSentence(input);

			var output = "ab 0";

			Assert.AreEqual(output, result);
		}
		[TestMethod]
		public void Number_thirty_seven()
		{
			var input = " thirty seven items ";
			var result = NumberUtility.ReduceSentence(input);

			var output = "37 items";

			Assert.AreEqual(output, result);
		}

	   [TestMethod]
		public void Number_2_millions()
		{
			var input = " two millions stars ";
			var result = NumberUtility.ReduceSentence(input);

			var output = "2000000 stars";

			Assert.AreEqual(output, result);
		}

		[TestMethod]
		public void Number_4_million()
		{
			var input = " four million seconds ";
			var result = NumberUtility.ReduceSentence(input);

			var output = "4000000 seconds";

			Assert.AreEqual(output, result);
		}

		[TestMethod]
		public void Number_one_hundred_thousand()
		{
			var input = " one hundred thousand items ";
			var result = NumberUtility.ReduceSentence(input);

			var output = "100000 items";

			Assert.AreEqual(output, result);
		}
	}
}

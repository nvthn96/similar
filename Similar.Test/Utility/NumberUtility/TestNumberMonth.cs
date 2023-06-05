using Similar.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Similar.Test.Utility
{
	[TestClass]
	public class TestNumberMonth
	{
		[TestMethod]
		public void Month()
		{
			var input = " the november ";
			var result = NumberUtility.ReduceSentence(input);

			var output = "the 11";

			Assert.AreEqual(output, result);
		}

		[TestMethod]
		public void Month_day()
		{
			var input = " the twenty eighth november ";
			var result = NumberUtility.ReduceSentence(input);

			var output = "2811";

			Assert.AreEqual(output, result);
		}

		[TestMethod]
		public void Month_date()
		{
			var input = " sunday november ";
			var result = NumberUtility.ReduceSentence(input);

			var output = "011";

			Assert.AreEqual(output, result);
		}
	}
}

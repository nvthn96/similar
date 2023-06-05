using Similar.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Similar.Test.Utility
{
	[TestClass]
	public class TestNumberDate
	{
		[TestMethod]
		public void Date_wed()
		{
			var input = " wed ";
			var result = NumberUtility.ReduceSentence(input);

			var output = "4";

			Assert.AreEqual(output, result);
		}

		[TestMethod]
		public void Date_monday()
		{
			var input = " monday ";
			var result = NumberUtility.ReduceSentence(input);

			var output = "2";

			Assert.AreEqual(output, result);
		}

		[TestMethod]
		public void Date_month()
		{
			var input = " monday november ";
			var result = NumberUtility.ReduceSentence(input);

			var output = "211";

			Assert.AreEqual(output, result);
		}
	}
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FirstLessonTests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void CallEqualOnEqualStrings_ReturnTrue()
		{
			var firstString = "string";
			var secondString = "string";

			var equal = firstString.Equals(secondString);

			Assert.IsTrue(equal);
		}

		[TestMethod]
		public void SumTwoNumbers_EqualToThirdNumber()
		{
			var firstNumber = 5;
			var secondNumber = 10;
			var expectedSumm = 15;

			var actual = firstNumber + secondNumber;

			Assert.AreEqual(expectedSumm, actual);
		}

		[TestMethod]
		public void DumbTest()
		{
			Assert.IsTrue(true);
		}
	}
}

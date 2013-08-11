using System;
using NUnit.Framework;

namespace EulerProblem4.Tests
{
	[TestFixture]
	public class PalindromeCandidate_UT
	{
		[Test]
		public void Product_Is_The_Multiple_Of_Two_Numbers()
		{
			var testObject = new PalindromeCandidate(5, 6);
			Assert.That (testObject.Product, Is.EqualTo (5 * 6));
		}

		[Test]
		public void IsPalindrome_Returns_False_When_Product_Is_Not_Palindrome()
		{
			var testObject = new PalindromeCandidate(5, 6);
			Assert.That (testObject.IsPalindrome, Is.False);
		}

		[Test]
		public void IsPalindrome_Returns_True_When_Product_Is_Palindrome()
		{
			var testObject = new PalindromeCandidate(91, 99);
			Assert.That (testObject.IsPalindrome, Is.True);
		}
	}
}


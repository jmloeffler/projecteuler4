using System;
using NUnit.Framework;

namespace EulerProblem4.Tests
{
	[TestFixture]
	public class PalindromeFinder_UT
	{
		[Test]
		public void Loop_Ranges_Are_The_Largest_And_Smallest_Numbers_Consisting_Of_X_Digits()
		{
			var testObject = new PalindromeFinder(2);
			Assert.That (testObject.MaxNumber, Is.EqualTo (99));
			Assert.That (testObject.MinNumber, Is.EqualTo (10));
		}

		[Test]
		public void Largest_Palindrome_From_Two_Digit_Numbers_Is_9009()
		{
			var testObject = new PalindromeFinder(2);
			Assert.That (testObject.FindPalindrome().Product, Is.EqualTo(9009));
		}
	}
}


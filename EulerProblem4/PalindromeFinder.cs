using System;

namespace EulerProblem4
{
	public class PalindromeFinder
	{
		public int MaxNumber;
		public int MinNumber;

		public PalindromeFinder (int numberOfFactorDigits)
		{
			MaxNumber = int.Parse ("".PadLeft(numberOfFactorDigits, '9'));
			MinNumber = int.Parse ("1".PadRight(numberOfFactorDigits, '0'));
		}

		public PalindromeCandidate FindPalindrome ()
		{
			for (int x = MaxNumber; x >= MinNumber; x--) {
				for(int y = MaxNumber; y >= MinNumber; y--) {
					var candidate = new PalindromeCandidate(x, y);
					if(candidate.IsPalindrome)
					{
						return candidate;
					}
				}
			}

			return new PalindromeCandidate(0, 0);
		}
	}
}


using System;

namespace EulerProblem4
{
	public class PalindromeCandidate
	{
		public int x;
		public int y;

		public PalindromeCandidate (int x, int y)
		{
			this.x = x;
			this.y = y;

			Product = x * y;
			IsPalindrome = (Product.ToString () == GetReversedProduct ());
		}

		public int Product { get; private set; }
		public bool IsPalindrome { get; private set; }

		private string GetReversedProduct ()
		{
			var productArray = Product.ToString ().ToCharArray ();
			Array.Reverse (productArray);
			return new String (productArray);
		}
	}

}


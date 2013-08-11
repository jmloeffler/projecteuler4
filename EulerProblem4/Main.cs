using System;

namespace EulerProblem4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int digits = 3;
			bool parsed = false;
			if(args.Length > 0)
				parsed = int.TryParse (args[0], out digits);
			if(!parsed)
				digits = 3;

			var finder = new PalindromeFinder(digits);
			var result = finder.FindPalindrome ();

			Console.WriteLine ("Largest palindrome that is a product of two {0}-digit numbers is {1}, formed by {2} and {3}",
			                   digits,
			                   result.Product,
			                   result.x,
			                   result.y);
		}
	}
}

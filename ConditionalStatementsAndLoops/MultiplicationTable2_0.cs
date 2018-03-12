using System;

namespace ConditionalStatementsAndLoops
{
	class MainClass
	{
		public static void Main ()
		{
			int num = int.Parse (Console.ReadLine ());
			int multiplier = int.Parse (Console.ReadLine ());
			int result;

			if (multiplier > 10) {
				result = num * multiplier;
				Console.WriteLine ($"{num} X {multiplier} = {result}");
			} else {
				for (int i = multiplier; i <= 10; i++) {
					result = num * i;
					Console.WriteLine ($"{num} X {i} = {result}");
				}
			}
		}
	}
}


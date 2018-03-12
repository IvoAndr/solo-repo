using System;

namespace ConditionalStatementsAndLoops
{
	class MainClass
	{
		public static void Main ()
		{
			int num = int.Parse (Console.ReadLine ());

			for (int i = 1; i <= 10; i++) {
				int result = num * i;
				Console.WriteLine ($"{num} X {i} = {result}");
			}
		}
	}
}


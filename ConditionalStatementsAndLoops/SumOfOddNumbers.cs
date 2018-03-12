using System;

namespace ConditionalStatementsAndLoops
{
	class MainClass
	{
		public static void Main ()
		{
			int numsCount = int.Parse (Console.ReadLine ());
			int sum = 0, num = 1;

			for (int i = 0; i < numsCount; i++) {
				Console.WriteLine (num);
				sum += num;
				num += 2;
			}

			Console.WriteLine ($"Sum: {sum}");
		}
	}
}


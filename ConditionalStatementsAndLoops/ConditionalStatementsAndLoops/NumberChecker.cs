using System;

namespace ConditionalStatementsAndLoops
{
	class MainClass
	{
		public static void Main ()
		{
			try {
				int.Parse(Console.ReadLine());
				Console.WriteLine("It is a number.");
			} catch (Exception) {
				Console.WriteLine ("Invalid input!");
			}
		}
	}
}


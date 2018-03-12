using System;

namespace ConditionalStatementsAndLoops
{
	class MainClass
	{
		public static void Main ()
		{
			int hours = int.Parse (Console.ReadLine ());
			int minutes = int.Parse (Console.ReadLine ());

			if (minutes + 30 >= 60) {
				hours++;
				minutes = minutes + 30 - 60;
			} else {
				minutes += 30;
			}

			if (hours > 23) {
				hours -= 24;
			}
			Console.Write ($"{hours}:");

			if (minutes < 10) {
				Console.Write ($"{minutes:D2}");
			} else {
				Console.Write ($"{minutes}");
			}
		}
	}
}


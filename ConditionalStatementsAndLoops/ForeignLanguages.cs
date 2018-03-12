using System;

namespace ConditionalStatementsAndLoops
{
	class MainClass
	{
		public static void Main ()
		{
			string countryName = Console.ReadLine ();

			if (countryName == "England" || countryName == "USA") {
				Console.WriteLine ("English");
			} else if (countryName == "Spain" || countryName == "Argentina"
			           || countryName == "Mexico") {
				Console.WriteLine ("Spanish");
			} else {
				Console.WriteLine ("unknown");
			}
		}
	}
}


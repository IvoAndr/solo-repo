using System;

namespace Intro_and_Basic_Syntax
{
	class MainClass
	{
		public static void Main ()
		{
			string drink = Console.ReadLine ();
			double volume = double.Parse (Console.ReadLine ());
			double energy = double.Parse (Console.ReadLine ());
			double sugar = double.Parse (Console.ReadLine ());

			Console.WriteLine ($"{volume}ml {drink}:");

			energy = volume / 100 * energy;
			sugar = volume / 100 * sugar;

			Console.WriteLine ($"{energy}kcal, {sugar}g sugars");
		}
	}
}


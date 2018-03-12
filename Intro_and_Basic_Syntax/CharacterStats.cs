using System;

namespace Intro_and_Basic_Syntax
{
	class MainClass
	{
		public static void Main ()
		{
			string name = Console.ReadLine ();
			int currentHealth = int.Parse (Console.ReadLine ());
			int maxHealth = int.Parse (Console.ReadLine ());
			int currentEnergy = int.Parse (Console.ReadLine ());
			int maxEnergy = int.Parse (Console.ReadLine ());

			Console.WriteLine ($"Name: {name}");

			string health = new string ('|', currentHealth) + new string ('.', maxHealth - currentHealth);
			Console.WriteLine ($"Health: |{health}|");

			string energy = new string ('|', currentEnergy) + new string ('.', maxEnergy - currentEnergy);
			Console.WriteLine ($"Energy: |{energy}|");

		}
	}
}


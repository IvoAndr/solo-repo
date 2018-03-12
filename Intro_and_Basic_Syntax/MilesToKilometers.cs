using System;

namespace Intro_and_Basic_Syntax
{
	class MainClass
	{
		public static void Main ()
		{
			double km = double.Parse (Console.ReadLine ());

			Console.WriteLine ("{0:F2}", km * 1.60934);
		}
	}
}
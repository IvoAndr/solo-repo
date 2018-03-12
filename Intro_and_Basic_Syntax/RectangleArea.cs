using System;

namespace Intro_and_Basic_Syntax
{
	class MainClass
	{
		public static void Main ()
		{
			double width = double.Parse (Console.ReadLine ());
			double height = double.Parse (Console.ReadLine ());

			Console.WriteLine ("{0:F2}", width * height);
		}
	}
}


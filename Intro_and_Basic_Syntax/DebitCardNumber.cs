using System;

namespace Intro_and_Basic_Syntax
{
	class MainClass
	{
		public static void Main ()
		{
			int firstNum = int.Parse (Console.ReadLine ());
			int secondNum = int.Parse (Console.ReadLine ());
			int thirdNum = int.Parse (Console.ReadLine ());
			int fourthNum = int.Parse (Console.ReadLine ());

			Console.WriteLine ($"{firstNum:D4} {secondNum:D4} {thirdNum:D4} {fourthNum:D4}");
		}
	}
}


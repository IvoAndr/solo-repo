using System;

namespace Intro_and_Basic_Syntax
{
	class MainClass
	{
		public static void Main ()
		{
			int firstNum = int.Parse (Console.ReadLine ());
			int secondNum = int.Parse (Console.ReadLine ());

			Console.WriteLine ($"{firstNum} + {secondNum} = {firstNum + secondNum}");
		}
	}
}


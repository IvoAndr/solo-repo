﻿using System;

namespace ConditionalStatementsAndLoops
{
	class MainClass
	{
		public static void Main ()
		{
			while (true) {
				int num = int.Parse(Console.ReadLine());
				if (num % 2 != 0) {
					Console.WriteLine($"The number is: {Math.Abs(num)}");
					break;
				}
				else {
					Console.WriteLine ("Please write an odd number.");
				}
			}
		}
	}
}

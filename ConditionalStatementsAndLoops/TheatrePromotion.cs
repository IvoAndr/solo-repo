using System;

namespace ConditionalStatementsAndLoops
{
	class MainClass
	{
		public static void Main ()
		{
			string dayType = Console.ReadLine ();
			int age = int.Parse (Console.ReadLine ());

			if (age < 0 || age > 122) {
				Console.WriteLine ("Error!");
				return;
			}

			string price;
			
			if (dayType == "Weekday") {
				if (age <= 18 || age > 64) {
					price = "12$";
				} else {
					price = "18$";
				}
			} else if (dayType == "Weekend") {
				if (age <= 18 || age > 64) {
					price = "15$";
				} else {
					price = "20$";
				}
			} else {
				if (age <= 18) {
					price = "5$";
				} else if (age <= 64) {
					price = "12$";
				} else {
					price = "10$";
				}
			}

			Console.WriteLine (price);
		}
	}
}


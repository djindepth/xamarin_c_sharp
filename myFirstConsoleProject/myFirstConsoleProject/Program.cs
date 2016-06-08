using System;

// switch case - correct answers
// compare answer - how close
// switch case - how close


namespace myFirstConsoleProject
{
	class MainClass
	{
		public static void Main (string[] args) //method
		{
			Start:
			int min = 0;
			int max = 10;
			int num01 = new Random ().Next (min, max);
			int num02 = new Random ().Next (min, max);
			int sum = num01 + num02;
			int ans;
			int dif;
			int abs;
			int myIndex = new Random ().Next (1, 4);
			//string ret;

			Console.WriteLine ("what is the sum of " + num01 + " and " + num02 + " ?");
			ans = Convert.ToInt32 (Console.ReadLine ());

			if (ans == sum) {

				switch (myIndex) {
				case 1:
					Console.WriteLine ("That is correct!");
					break;
				case 2:
					Console.WriteLine ("You are good!");
					break;
				default:
					Console.WriteLine ("So Smart!");
					break;
				}
			} else {

				dif = ans - sum;
				abs = Math.Abs(dif); 
				Console.WriteLine ("That is incorrect. You should try again.");
				Console.WriteLine ("You were off by: " + abs);
			}

			/*Console.WriteLine ("Shall we try again? Type Y for Yes and N for No");
			ret = Console.ReadLine ();
			if (ret == "y") {

			} else if (ret == "n") {

			} else {
				Console.WriteLine ("Not an option.");
			}*/
			Console.ReadKey ();
			goto Start;


		}
	}
}

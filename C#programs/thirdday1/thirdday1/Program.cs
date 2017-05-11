using System;

namespace thirdday1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("How much money do you want to pay with?");

			decimal cash = Convert.ToDecimal(Console.ReadLine());

			Console.WriteLine("How much did you spend?");

		decimal spend = Convert.ToDecimal(Console.ReadLine());

			decimal change = cash - spend;



			Console.WriteLine();

			Console.WriteLine("You will have $" + change + " change leftover.");

			Console.WriteLine();
			       
			decimal x = Math.Floor(change);
			decimal y = change - x;
			decimal x1;
			decimal x2;
			decimal y1;
			decimal y2;
			if (x >= 20)
			{
				x1 = x / 20;
				x2 = Math.Floor(x1);
				Console.WriteLine("you will get " + x2 + " twenties");
				x = x - (x2 * 20);
			}
			if (x >= 10)
			{
				x1 = x / 10;
				x2 = Math.Floor(x1);
				Console.WriteLine("you will get " + x2 + " tens");
				x = x - (x2 * 10);
			}
			if (x > 0)
			{
				Console.WriteLine("you will get " + x + " oncs");
			}

			if (y >= .25m)
			{
				y1 = y / .25m;
				y2 = Math.Floor(y1);
				Console.WriteLine("you will get " + y2 + " Quarters");
				y = y - (y2 * .25m);
			}
			if (y >= .10m)
			{
				y1 = y / .10m;
				y2 = Math.Floor(y1);
				Console.WriteLine("you will get " + y2 + " Dimes");
				y = y - (y2 * .10m);
			}
			if (y >= .05m)
			{
				y1 = y / .05m;
				y2 = Math.Floor(y1);
				Console.WriteLine("you will get " + y2 + " Nickls");
				y = y - (y2 * .05m);
			}
			if (y > 0)
			{
				y = y * 100;
				y = Math.Floor(y);
				Console.WriteLine("you will get " + y + " pennies");
			}
		}

			}

		}

	


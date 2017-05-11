using System;

namespace soccerleague
{
	class MainClass
	{
		/*public static void Main(string[] args)
            {
			Console.WriteLine("Enter the radius of your circle\n");
			string stringradius = Console.ReadLine();
			double radius = Convert.ToDouble(stringradius);
			double area = Math.PI * radius * radius;
			area = Math.Round(area);
			Console.WriteLine("\nthe area of your circle will be " + area + ":\n");
			int bucket = 0;
			int cost;
			Console.WriteLine("\nWhat color do you want to paint? Red, blue, green or yellow?\n");
			string color = Console.ReadLine();
			switch (color)
			{
				case "red":
					while (area > 100)
					{
						area = area - 100;
						bucket = bucket + 1;
					}
					bucket = bucket + 1;
					Console.WriteLine("\nIt will take " + bucket + " buckets to paint the " + radius + " radius circle with red color\n ");
					cost = bucket * 25;
					Console.WriteLine("\nIt will cost $" + cost + " to paint your circle with red.\n");
					break;
				case "blue":
					while (area > 120)
					{
						area = area - 120;
						bucket = bucket + 1;
					}
					bucket = bucket + 1;
					Console.WriteLine("\nIt will take " + bucket + " buckets to paint the " + radius + " radius circle with blue color\n");
					cost = bucket * 28;
					Console.WriteLine("\nIt will cost $" + cost + " to paint your circle with blue.\n");
					break;
				case "yellow":
					while (area > 70)
					{
						area = area - 70;
						bucket = bucket + 1;
					}
					bucket = bucket + 1;
					Console.WriteLine("\nIt will take " + bucket + " buckets to paint the " + radius + " radius circle with yellow color\n");
					cost = bucket * 22;
					Console.WriteLine("\nIt will cost $" + cost + " to paint your circle with yellow.\n");
					break;
				case "green":
					while (area > 90)
					{
						area = area - 90;
						bucket = bucket + 1;
					}
					bucket = bucket + 1;
					Console.WriteLine("\nIt will take " + bucket + " buckets to paint the " + radius + " radius circle with green color\n");
					cost = bucket * 33;
					Console.WriteLine("\nIt will cost $" + cost + " to paint your circle with green.\n");
					break;
			}
		}
	}
}*/
		// mary's way
		public static void Main(string[] args)
		{
			Console.WriteLine("What is the radius of the center circle in feet?");
			string radius_string = Console.ReadLine();
			double x = Convert.ToDouble(radius_string);

			Console.WriteLine("Would you like to use red, blue, green, or yellow paint?");
			string c = Console.ReadLine().ToLower();

			double a = CalArea(x);
			double b = BucketNumber(c, a);
		

			Console.WriteLine("It will take " + b + " buckets of " + c + " paint to cover the " + x + "' radius circle.");
			Console.WriteLine("and the cost will be for that is  $" + PaintCost(c,b));
				Console.ReadLine();

		}



		static double CalArea(double radius)
		{
			double area = 0;
			area = Math.PI * Math.Pow(radius, 2);
			return area;
		}


		static double BucketNumber(string color,double area)
		{
			double bucket=0;
			if (color == "red")
			{
				bucket = Math.Ceiling(area / 100);
			}
			else if (color == "blue")
			{
				bucket = Math.Ceiling(area / 120);
			}
			else if (color == "green")
			{
				bucket = Math.Ceiling(area / 90);
			}
			else if (color == "yellow")
			{
				bucket = Math.Ceiling(area / 70);
			}
			return bucket;
		}



		static double PaintCost(string color,double bucket)
		{
			double cost = 0;
				if (color == "red")
				{
					cost = bucket * 25;
				}
				else if (color == "blue")
				{
					cost = bucket * 28;
				}
				else if (color == "green")
				{
					cost = bucket * 33;
				}
				else if (color == "yellow")
				{
					cost = bucket * 22;
				}
			return cost;
		}


	}
}
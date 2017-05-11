using System;

namespace Helloworld
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			/*
			Console.WriteLine( 2 + 2 );
			Console.WriteLine(2*(24+36));
			Console.WriteLine(2 * Math.PI * 10);
			Console.WriteLine( "AAAAA" .Replace("A" , "Hello World"));
			Console.WriteLine("hello world".ToUpper());
			Console.ReadLine();
			//Console.WriteLine("hi again");
			int a;
			a = 2;
			Console.WriteLine("a=" + a);
			string somestring = "23";
			int number = Convert.ToInt16(somestring);
			Console.WriteLine( number);
			*/
		
			Console.WriteLine(" please enter the Length of your garden bed ! ");
			string lenn = Console.ReadLine();
			int len = Convert.ToInt16(lenn);
			Console.WriteLine(" please enter the Width of your garden bed ! ");
			String widd = Console.ReadLine();
			int wid = Convert.ToInt16(widd);
			int area = wid * len;
			Console.WriteLine(" the area of your garden bed is: " + area);
			int perim = (wid + len) * 2;


			double f1 = .1875;
			double f2 = .5625;

			Console.WriteLine(" the perimeter of your garden bed is: " + perim);

			Console.WriteLine(" what do you want to plant?");
			string wanted = Console.ReadLine();

			if (wanted == "carrot")

			{
				Console.WriteLine(" you can plant " + area + "  carrot in your garden");
			}

			if (wanted == "corn")
			{
				Console.WriteLine(" you can plant " + (f1 * area) + "  Corn in your garden");
			}

			if (wanted == "beet")
			{
				Console.WriteLine(" you can plant " + (f2 * area) + "  beet in your garden");
			}
		}
	}
}

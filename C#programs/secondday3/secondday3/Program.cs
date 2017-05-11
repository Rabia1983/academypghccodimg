using System;

namespace secondday3
{
	class MainClass
	{
		public static void Main(string[] args)
		{


			for (int num = 1; num < 100; num++)
			{

				if (num % 3 == 0 && num % 5 != 0)
				{
					Console.WriteLine("Fizz");

				}
				if ((num % 5 == 0) && (num % 3 != 0))
				{
					Console.WriteLine("Bizz");

				}
				if ((num % 5 == 0) && (num % 3 == 0))
				{
					Console.WriteLine("Bizzbuzz");
				
				}

				if ((num % 5 != 0) && (num % 3 != 0))
				{
					Console.WriteLine(num);

				}
			}


			/*Console.WriteLine("enter the number which you want to count by ");
			string xx = Console.ReadLine();
			int x = Convert.ToUInt16(xx);
		    int y = 1;
			while (y <= 150)
			{
				Console.WriteLine(y);
				y = y + x;
			}*/

		}
	}
}

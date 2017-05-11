using System;

namespace arraysorting
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			
			int[] inbox = new int[10];
			int i = 0;
	
			Console.WriteLine("enter the numbers you want to save ");
			while (i < 10)
			{
				string input = Console.ReadLine();
				int num = Convert.ToInt16(input);
				inbox[i] = num;
				i++;
			}
			Console.WriteLine("your array befor sorting is : ");
			PrintArr(inbox);
			int[] testes = SortArr(inbox);
			Console.WriteLine("your array after sorting is : ");
			PrintArr(testes);
				

		}

		static int[] SortArr(int[] inbox)
		{
			int d = 0;
			int test;

			while (d < inbox.Length)
			{
				for (int y = (d + 1); y < inbox.Length; y++)
				{
					if (inbox[y] <= inbox[d])
					{
						test = inbox[d];
						inbox[d] = inbox[y];
						inbox[y] = test;

					}
				}
				d++;
			}
			return inbox;
		}

		static bool PrintArr(int[] inbox)
		{
			bool b = true;
			for (int h = 0; h < 10; h++)
			{
				Console.WriteLine(inbox[h]);
			}
			return b;
		}





	}
}

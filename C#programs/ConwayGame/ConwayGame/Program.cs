using System;
using System.Threading;

namespace ConwayGame
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Random rnd = new Random();
			string[,] grid = new string[20, 20];
			for (int x = 0; x < 20; x++)
				{
					for (int y = 0; y < 20; y++)
					{
						grid[x, y] = "0";
					}
				}
			// add some Randome life
			for (int i = 0; i < 100; i++)
			{
				int d = rnd.Next(0, 19);
				int h = rnd.Next(0, 19);
				grid[d, h] = "*";
			} 
			while (true)
			{
				string[,] grid1 = new string[20, 20];
				int nie = 0;
				for (int x = 0; x < 20; x++)
				{
					for (int y = 0; y < 20; y++)
					{
						if ((x == 0) && (y == 0)) { nie = FirstCorner(grid, x, y); }
						else if ((x == 0) && (y == 19)) { nie = SecondCorner(grid, x, y); }
						else if ((x == 19) && (y == 0)) { nie = Thirdcorner(grid, x, y); }
						else if ((x == 19) && (y == 19)) { nie = FourthCorner(grid, x, y); }
						else if ((x == 0) && (y > 0) && (y < 19)) { nie = FirstTopLine(grid, x, y); }
						else if ((x == 19) && (y > 0) && (y < 19)) { nie = LastBottomLine(grid, x, y); }
						else if ((y == 0) && (x > 0) && (x < 19)) { nie = FirstLeftCol(grid, x, y); }
						else if ((y == 19) && (x > 0) && (x < 19)) { nie = LastRightCol(grid, x, y); }
						else { nie = NormalCel(grid, x, y); }
						if ((grid[x, y] == "*" && nie == 0) || (grid[x, y] == "*" && nie == 1) || (grid[x, y] == "*" && nie > 3))
						{
							grid1[x, y] = "0";
						}
						else if ((grid[x, y] == "*" && nie == 2) || (grid[x, y] == "*" && nie == 3) || (grid[x, y] == "0" && nie == 3))
						{
							grid1[x, y] = "*";
						}
						else grid1[x, y] = grid[x, y];
					}
				}
				Console.WriteLine();
				Console.WriteLine();
		        grid = grid1;

	     for (int x = 0; x < 20; x++)
			{
				for (int y = 0; y < 20; y++)
				{
						if (grid[x, y] == "*")
						{
							Console.Write(grid[x, y] + "  ");
						}
				}
				Console.WriteLine();
			}
				Thread.Sleep(500);
			}

			
		}
		static int FirstCorner(string[,] array,int i,int j)
		{
			int nieghbor = 0;
			if (array[i,j+1]=="*") { nieghbor += 1; }
			if (array[i+1,j] == "*") { nieghbor += 1; }
			if (array[i+1,j+1] == "*") { nieghbor += 1; }
			return nieghbor;
		}

		static int SecondCorner(string[,] array, int i, int j)
		{
			int nieghbor = 0;
			if (array[i, j - 1] == "*") { nieghbor += 1; }
			if (array[i + 1, j] == "*") { nieghbor += 1; }
			if (array[i +1, j-1] == "*") { nieghbor += 1; }
			return nieghbor;
		}

		static int Thirdcorner(string[,] array, int i, int j)
		{
			int nieghbor = 0;
			if (array[i, j + 1] == "*") { nieghbor += 1; }
			if (array[i-1, j] == "*") { nieghbor += 1; }
			if (array[i-1, j+1] == "*") { nieghbor += 1; }
			return nieghbor;
		}

		static int FourthCorner(string[,] array, int i, int j)
		{
			int nieghbor = 0;
			if (array[i-1,j] == "*") { nieghbor += 1; }
			if (array[i,j-1] == "*") { nieghbor += 1; }
			if (array[i-1,j-1] == "*") { nieghbor += 1; }
			return nieghbor;
		}

		static int FirstTopLine(string[,] array, int i, int j)
		{
			int nieghbor = 0;
			if (array[i,j+1] == "*") { nieghbor += 1; }
			if (array[i,j-1] == "*") { nieghbor += 1; }
			if (array[i+1,j] == "*") { nieghbor += 1; }
			if (array[i+1,j+1] == "*") { nieghbor += 1; }
			if (array[i+1,j-1] == "*") { nieghbor += 1; }
			return nieghbor;
		}

		static int LastBottomLine(string[,] array, int i, int j)
		{
			int nieghbor = 0;
			if (array[i,j-1] == "*") { nieghbor += 1; }
			if (array[i,j+1] == "*") { nieghbor += 1; }
			if (array[i-1,j+1] == "*") { nieghbor += 1; }
			if (array[i-1,j-1] == "*") { nieghbor += 1; }
			if (array[i-1,j] == "*") { nieghbor += 1; }
			return nieghbor;
		}

		static int FirstLeftCol(string[,] array, int i, int j)
		{
			int nieghbor = 0;
			if (array[i-1,j] == "*") { nieghbor += 1; }
			if (array[i+1,j] == "*") { nieghbor += 1; }
			if (array[i,j+1] == "*") { nieghbor += 1; }
			if (array[i-1,j+1] == "*") { nieghbor += 1; }
			if (array[i+1,j+1] == "*") { nieghbor += 1; }
			return nieghbor;
		}

		static int LastRightCol(string[,] array, int i, int j)
		{
			int nieghbor = 0;
			if (array[i-1,j] == "*") { nieghbor += 1; }
			if (array[i+1,j] == "*") { nieghbor += 1; }
			if (array[i,j-1] == "*") { nieghbor += 1; }
			if (array[i+1,j-1] == "*") { nieghbor += 1; }
			if (array[i-1,j-1] == "*") { nieghbor += 1; }
			return nieghbor;
		}

		static int NormalCel(string[,] array, int i, int j)
		{
			int nieghbor = 0;
			if (array[i,j+1] == "*") { nieghbor += 1; }
			if (array[i,j-1] == "*") { nieghbor += 1; }
			if (array[i+1,j] == "*") { nieghbor += 1; }
			if (array[i+1,j+1] == "*") { nieghbor += 1; }
			if (array[i+1,j-1] == "*") { nieghbor += 1; }
			if (array[i-1,j] == "*") { nieghbor += 1; }
			if (array[i-1,j-1] == "*") { nieghbor += 1; }
			if (array[i-1,j+1] == "*") { nieghbor += 1; }

			return nieghbor;
		}
	}
}

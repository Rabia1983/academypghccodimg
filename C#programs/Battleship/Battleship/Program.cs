/*using System;

namespace Battleship
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string[,] grid = new string[8, 8];
			//Console.WriteLine(grid.Length);
		//	string idisplay = "ABCDEFGH";


			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					grid[i, j] = "0";
				}
			}

			for (int i = 0; i < 8; i++)
			    {
				   for (int j = 0; j < 8; j++)
					{
						
						Console.Write(grid[i, j] + "  ");
					}
					Console.WriteLine();
				}
			
		
			grid[1, 4] = "*";
			grid[2, 2] = "*";
			grid[2, 3] = "*";
			grid[4, 3] = "*";
			grid[4, 4] = "*";
			grid[5, 0] = "*";
			grid[5, 2] = "*";
			grid[6, 5] = "*";
			grid[6, 6] = "*";
			grid[7, 2] = "*";
			grid[7, 3] = "*";
			grid[7, 4] = "*";
			grid[7, 5] = "*";

			int deleted_ship = 0;

		
			for (int a = 1; a <= 13; a++)
			{
				
				Console.WriteLine("enter you colomn number !");
				string string_colomn = Console.ReadLine();
				int colomn_num = Convert.ToInt32(string_colomn);
				Console.WriteLine("enter you raw number !");
				string string_raw = Console.ReadLine();
				int raw_num = Convert.ToInt32(string_raw);
				if (grid[colomn_num, raw_num] == "*")
				{
					Console.WriteLine("Congrats!!!! you did it,try again you still have " + (15 - a) + " times");
					grid[colomn_num, raw_num] = "$";
					deleted_ship = deleted_ship + 1;
				}
				else if((grid[colomn_num, raw_num-1] == "*")||(grid[colomn_num, raw_num+1] == "*")
				       ||(grid[colomn_num-1, raw_num] == "*")||(grid[colomn_num+1, raw_num] == "*"))
				{
					Console.WriteLine("you are soo close!!!");
				}
				else
				{
					Console.WriteLine("you faild ......try again you still have " +(15-a)+" times");
					grid[colomn_num, raw_num] = "#";
				}
				if (deleted_ship == 12)
				{
					Console.WriteLine("GAME OVER!!!!!");
					break;
				}

				//Console.Clear();

				for (int i = 0; i < 8; i++)
				{
					for (int j = 0; j < 8; j++)
					{
						if (grid[i,j]=="o" || grid[i,j]=="#"|| grid[i, j] == "$" )
						{
							Console.Write(grid[i, j] + "  ");
						}
						else
						{
							string y = grid[colomn_num, raw_num];
							grid[colomn_num, raw_num] = "0";
							Console.Write(grid[colomn_num, raw_num] + "  ");
							grid[colomn_num, raw_num] = y;

						}
					}
					Console.WriteLine();
				}

			}

			Console.ReadLine();
		}
	}
}*/
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace BattleshipSession3

{

	class Program

	{

		static void Main(string[] args)

		{

			// Create grid variable name

			int[,] grid;

			// Allocate memory for grid

			grid = new int[8, 8];



			// Fill grid with water

			for (int i = 0; i < 8; i++)

			{

				for (int j = 0; j < 8; j++)

				{

					grid[i, j] = 0;

				}

			}



			// Place Ships

			Random rnd;

			rnd = new Random();



			for (int i = 0; i < 5; i++)

			{

				int random_x = rnd.Next(7);

				int random_y = rnd.Next(7);

				grid[random_y, random_x] = 1;

			}



			while (true)

			{

				// Draw Grid

				Console.Clear();

				Console.WriteLine("    0  1  2  3  4  5  6  7 ");

				for (int i = 0; i < 8; i++)

				{

					Console.Write(" " + i + " ");

					for (int j = 0; j < 8; j++)

					{



						if (grid[i, j] == 0) // Open Water

						{

							Console.Write("[0]");

						}

						else if (grid[i, j] == 1) // Has a ship

						{

							Console.Write("[-]");

						}

						else if (grid[i, j] == 2) // Blown up ship

						{

							Console.Write("[*]");

						}

					}

					Console.WriteLine();

				}



				// Get Input

				Console.WriteLine("Enter the coordinates to shoot. Ex: 2,3");

				string input = Console.ReadLine();

				string[] coords = input.Split(',');

				int x;

				int y;

				y = Convert.ToInt32(coords[0]);

				x = Convert.ToInt32(coords[1]);





				// Update Grid

				if (grid[y, x] == 1)

				{

					// hit!

					Console.WriteLine("You hit!");

					grid[y, x] = 2;

				}

				else

				{

					// miss!

					Console.WriteLine("You missed!");

				}

				Console.WriteLine("Press enter to continue");

				Console.ReadLine();

			}



		}

	}

}

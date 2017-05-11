using System;
using Mono.Data.Sqlite;
using System.Data;

namespace AlbumsDB
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			SqliteConnection connection = new SqliteConnection(@"Data Source=/Users/moonroor/Projects/AlbumsDB/AlbumsDB/Properties/albumexample.sqlite");
			SqliteCommand command;
			SqliteDataReader reader;
			connection.Open();
			while (true)
			{
				String userInput = "";
				Console.WriteLine("What do you want to do?\n   Add a (S)ong\n   Add an (A)lbum\n   (L)ist the songs and albums\n   e(X)it?");
				userInput = Console.ReadLine().ToUpper();
				if (userInput == "S")
				{
					command = new SqliteCommand("SELECT * FROM ALbum", connection);
					reader = command.ExecuteReader();

					if (reader.HasRows)
					{
						while (reader.Read())
						{
							Console.WriteLine($"{reader["Id"]} - {reader["Name"]} - {reader["Artist"]}");
						}
					}
					reader.Close();

					Console.WriteLine("What album number do you want to add a song to?");
					int albumToEdit = Convert.ToInt32(Console.ReadLine());
					Console.Write("Name of Song:  ");
					string userSong = Console.ReadLine();
					Console.Write("Song Length (MM:SS):  ");
					string userLength = Console.ReadLine();
					command = new SqliteCommand($"INSERT INTO Songs (Album_ID, Title, Length) VALUES ('{albumToEdit}', '{userSong}', '{userLength}')", connection);
					command.ExecuteNonQuery();
				 }
				else if (userInput == "A")
				{
					Console.WriteLine("Who is the artist of the album?");
					string userArtist = Console.ReadLine();
					Console.WriteLine("What is the name of the album?");
					string userName = Console.ReadLine();
					Console.WriteLine("What year was the album?");
					int userYear = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("What is the genre?");
					string userGenre = Console.ReadLine();
					command = new SqliteCommand($"INSERT INTO Album (Artist, Name, Year, Genre) VALUES ('{userArtist}', '{userName}', '{userYear}', '{userGenre}')", connection);
					reader = command.ExecuteReader();
					reader.Close();
				}
				else if (userInput == "L")
				{
					command = new SqliteCommand("SELECT * FROM Songs JOIN ALbum ON Songs.Album_Id = Album.Id", connection);
					reader = command.ExecuteReader();
					if (reader.HasRows)
					{
						while (reader.Read())
						{
							Console.WriteLine($"{reader["Id"]} - {reader["Title"]} - {reader["Length"]}\n{reader["Album_ID"]} - {reader["name"]}\n{reader["Year"]}. {reader["Genre"]}\n");
						}
					}
					reader.Close();
				}
				else if (userInput == "X")
				{
					Console.WriteLine("Good bye!");
					break;
				}
				else
				{
					Console.WriteLine($"{userInput} was not recognized as a valid respone.  Please try again.");
				}
			}//END OF MAIN LOOP
			connection.Close();
		}
	}
}

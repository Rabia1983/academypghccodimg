using System;
using Mono.Data.Sqlite;

namespace monodatabase
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			SqliteConnection connection = new SqliteConnection(@"Data Source=./example.sqlite;");
			connection.Open();
			SqliteCommand command = new SqliteCommand("select * from Address;", connection);
			//SqliteCommand command = new SqliteCommand("insert into address (name, address) VALUES ('Linda', 'Somewhere near here');", connection);
			SqliteDataReader reader = command.ExecuteReader();
			//command.ExecuteNonQuery();

            while (reader.Read())

			{

				Console.WriteLine(reader["Name"]);

			}
			connection.Close();

			Console.WriteLine("Hello World!");
		}
	}
}


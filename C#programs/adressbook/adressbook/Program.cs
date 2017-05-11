using System;
using Mono.Data.Sqlite;

namespace adressbook
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			/*	SqliteConnection connection = new SqliteConnection(@"Data Source =/Users/moonroor/Projects/adressbook/adressbook/Properties/book.sqlite;");
				connection.Open();
				//SqliteCommand command = new SqliteCommand("insert into addressbook (FirstName,LastName,Address1,City,State,Zip,Email) VALUES ('Rabia','Almakhoul','922 Lynwood','Cranberry','pa','15055','ma@test.com'); ",connection);
				//command.ExecuteNonQuery();
				SqliteCommand command = new SqliteCommand("select * from addressbook;", connection);
				SqliteDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					Console.WriteLine(reader["FirstName"] + "," + reader["LastName"] + "," + reader["Email"]);
				}
				connection.Close();*/
			Console.WriteLine("Do you Want to (I)nsert,(S)ee everything,(U)pdateing or (D)eleting ?");
			string answer = Console.ReadLine();
			if (answer.ToUpper() == "I")
			{
				Console.WriteLine("What is your First Name ?");
				string fname = Console.ReadLine();
				Console.WriteLine("What is your Last Name ?");
				string lname = Console.ReadLine();
				Console.WriteLine("What is your Address ?");
				string addr = Console.ReadLine();
				Console.WriteLine("What is your City ?");
				string city = Console.ReadLine();
				Console.WriteLine("What is your State ?");
				string state = Console.ReadLine();
				Console.WriteLine("What is your Zip code ?");
				string zip = Console.ReadLine();
				Console.WriteLine("What is your Email ?");
				string mail = Console.ReadLine();
				bool b = insertItem(fname, lname, addr, city, state, zip, mail);
				Console.WriteLine(b);

				
			}
			else if (answer.ToUpper() == "S")
			{
				string[] t = new string[100];
				t = seeall();
				for (int i = 0; i < t.Length; i++)
				{
					if (t[i] != null)
					Console.WriteLine(t[i]);
				}
				
			}
			else if (answer.ToUpper() == "D")
			{
				Console.WriteLine("What do you want to delete by (F)irstname,(L)astname,(A)ddress,(C)ity,(S)tate,(Z)ipcode or(E)mail?");
				string a = Console.ReadLine();
				if (a == "F")
				{
					string colomname = "FirstName";
					Console.WriteLine("enter your first name");
					string info = Console.ReadLine();
					bool b =deleteing(colomname, info);
					Console.WriteLine(b);
					
				}
			}
			else if (answer.ToUpper() == "U")
			{
Console.WriteLine("What do you want toUpdate (F)irstname,(L)astname,(A)ddress,(C)ity,(S)tate,(Z)ipcode or(E)mail?");
				string a = Console.ReadLine();
				if (a == "F")
				{
					string colomname = "FirstName";
					Console.WriteLine("enter your old first name");
					string oldname = Console.ReadLine();
					Console.WriteLine("enter your new  first name");
					string newname = Console.ReadLine();
					updating(colomname, oldname, newname);

				}

				}


		}

		public static  bool  insertItem(string FName,string  LName,string Addre,string Cit,string Sta,string Zi,string Ema)
		{
			bool test = true;
		SqliteConnection connection = new SqliteConnection(@"Data Source =/Users/moonroor/Projects/adressbook/adressbook/Properties/book.sqlite;");
		connection.Open();
			SqliteCommand command = new SqliteCommand("insert into addressbook (FirstName,LastName,Address1,City,State,Zip,Email) VALUES ('"+FName+"','"+ LName +"','"+Addre+"','"+Cit+"','"+Sta+"','"+Zi+"','" + Ema+"'); ",connection);
		command.ExecuteNonQuery();
		connection.Close();
			return test;
		}

		public static string[] seeall()
		{
			string[] arr = new string[100];
			SqliteConnection connection = new SqliteConnection(@"Data Source =/Users/moonroor/Projects/adressbook/adressbook/Properties/book.sqlite;");
			connection.Open();
			SqliteCommand command = new SqliteCommand("select * from addressbook;", connection);
			SqliteDataReader reader = command.ExecuteReader();
			int i = 0;
			while (reader.Read())
			{
				arr[i] = reader["FirstName"].ToString();
				i = i + 1;
				arr[i] = reader["LastName"].ToString();
				i = i + 1;
				arr[i] = reader["Address1"].ToString();
				i = i + 1;
				arr[i] = reader["City"].ToString();
				i = i + 1;
				arr[i] = reader["State"].ToString();
				i = i + 1;
				arr[i] = reader["Zip"].ToString();
				i = i + 1;
				arr[i] =reader["Email"].ToString();
				i = i + 1;
			}
			connection.Close();
			return arr;
		}

		public static bool deleteing(string colnam, string tobedeleted)
		{
			bool b = true;
			SqliteConnection connection = new SqliteConnection(@"Data Source =/Users/moonroor/Projects/adressbook/adressbook/Properties/book.sqlite;");
			connection.Open();
			SqliteCommand command = new SqliteCommand("delete from addressbook WHERE  "+colnam+" = '"+tobedeleted+"'; ", connection);
			command.ExecuteNonQuery();
			connection.Close();
			return b;
		}

				public static bool updating(string colnam, string oldnam,string newnam)
		{
			bool b = true;
			SqliteConnection connection = new SqliteConnection(@"Data Source =/Users/moonroor/Projects/adressbook/adressbook/Properties/book.sqlite;");
			connection.Open();
				SqliteCommand command = new SqliteCommand("Update addressbook SET "+colnam+" = '"+newnam+"' WHERE "+colnam+" = '"+oldnam+"';", connection);
			command.ExecuteNonQuery();
			connection.Close();
			return b;
		}


	}
}

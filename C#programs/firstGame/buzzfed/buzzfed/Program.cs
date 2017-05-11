using System;
using Mono.Data.Sqlite;


namespace buzzfed
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			bool keepplaying = true;
			SqliteConnection connection = new SqliteConnection(@"Data Source=/Users/moonroor/Projects/buzzfed/buzzfedexample.slite");
			connection.Open();
			SqliteCommand deleteuseranswer = new SqliteCommand("delete from useranswers;", connection);
			deleteuseranswer.ExecuteNonQuery();
			SqliteCommand command;
			SqliteDataReader reader;
			int i = 0;
			string[] arr = new string[10];
			string userid = "";

			while (keepplaying == true)
			{
				Console.WriteLine("Do you want to take a (Q)uiz or e(X)it");
				string answer = Console.ReadLine().ToUpper();
				if (answer == "Q")
				{
					Console.WriteLine("What is your name?");
					string username = Console.ReadLine();
					command = new SqliteCommand("insert into Users (Name) values ('"+ username +"');select last_insert_rowid() as id",connection);
					reader = command.ExecuteReader();
					if (reader.HasRows)
					{
						 userid = reader["id"].ToString();	
					}
					reader.Close();
					Console.WriteLine("What Quiz would you like to do?");
					command = new SqliteCommand("select * from Quiz;",connection);
					reader = command.ExecuteReader();
					if (reader.HasRows)
					{
						//int quizecounter = 1;
						while (reader.Read())
						{
							Console.WriteLine($"These are the avalable Quizzes:\n {reader["id"]} -{reader["Name"]}");
							//quizecounter++;
						}
					}
					Console.Write("Type in the Quiz nomber: ");
					int quizchoice = Convert.ToInt16(Console.ReadLine());
					reader.Close();
					// push the qize_id into result table;
					SqliteCommand questionscommand = new SqliteCommand($"SELECT * FROM Questions JOIN Answers ON Questions.id = Answers.question_id WHERE Questions.quiz_id = {quizchoice}", connection);
					reader = questionscommand.ExecuteReader();
					if (reader.HasRows)
					{
						string oldQuestion = "";
						string x = "";

						while (reader.Read())
						{
							if (reader["id"].ToString() != oldQuestion)
							{
								
								x = oldQuestion;
								if (x != reader["id"].ToString() && oldQuestion!="")
								{
									Console.WriteLine("please enter your answer ");
									arr[i] = Console.ReadLine();
									i = i + 1;


								}
								Console.WriteLine($"{reader["title"]}");

								oldQuestion = reader["id"].ToString();

							}

							Console.WriteLine($" * {reader["text"]}");

						}
						if (x != reader["id"].ToString() && oldQuestion != "")
						{
							Console.WriteLine("please enter your answer ");
							arr[i] = Console.ReadLine();
							i = i + 1;

						}

					}
					reader.Close();
					string[] arr1 = new string[10];
					for (int x = 0; x < arr.Length - 1; x++)
					{
						SqliteCommand firstanswerscommand = new SqliteCommand($"select id from Answers WHERE Text = '{arr[x]}';", connection);
						reader = firstanswerscommand.ExecuteReader();
						reader.Read();
						arr1[x]=reader["id"].ToString();


						SqliteCommand secondanswerscommand = new SqliteCommand($"insert into useranswers (user_Id,answer_id)values('{userid}','{arr1[x]}');", connection);
						secondanswerscommand.ExecuteNonQuery();
					}

					reader.Close();
					SqliteCommand resultcommand = new SqliteCommand("select Title from results inner join Answers on results.id=answers.result_id inner join UserAnswers on answers.id = useranswers.answer_id;", connection);
					reader	= resultcommand.ExecuteReader();
					if (reader.HasRows)
					{
						if (reader.Read()) 
						{
							Console.WriteLine("Your Result is:" + reader["title"]);
						}
					}
					
				}
				else if (answer == "X")
				{
					Console.WriteLine("Thank you for your taking our Quiz.");
					keepplaying = false;
				}
				else
				{
					Console.WriteLine($"{answer} was not a valid response , please try now !");
				}
			}
			connection.Close();

		}
	}
}

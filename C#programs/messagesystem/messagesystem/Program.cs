using System;

namespace messagesystem
{
	class Program
	{
		static void Main(string[] args)
		{
			//by John
			// What do you want to do?
			// S) Save a message
			// R) Retrieve a message
			// L) List back end data
			// Q) Quit
			string[] messages = new string[10];
			int x = 0;
			bool something = true;
			while (something == true)
			{
				// Show the menu option
				Console.WriteLine("What do you wish to do?");
				Console.WriteLine("S) Save a message \nR) Retrieve a message");
				Console.WriteLine("L) List back end data \nQ) Quit");
				// Get the option selected
				string menu_choice = Console.ReadLine().ToUpper();
				switch (menu_choice)

				{
					case "S":
						Console.WriteLine("What is your message?");
						// get unencrypted
						string unencrypted = Console.ReadLine();
						// encrypt it
						string encrypted = "";// something!
						for (int j = 0; j < unencrypted.Length; j++)
						{
							encrypted = encrypted + (char)(unencrypted[j] + 5);
						}
						// save it to message store
						messages[x] = encrypted;
						Console.WriteLine("Your message ID is: " + x);
						x = x + 1;
						break;

					case "R":

						Console.WriteLine("What is the message id you wish to retrieve?");

						int message_id = Convert.ToInt32(Console.ReadLine());

						Console.Write("Your message is: ");

						string user_message = messages[message_id];
						for (int i = 0; i < user_message.Length; i++)
						{
							Console.Write((char)(user_message[i] - 5));
						}
						break;
					case "L":
						for (int i = 0; i < messages.Length; i++)
						{
							Console.WriteLine(messages[i]);
						}
						break;
					case "Q":
						Console.WriteLine("Thanks for using my messaging system.");
						something = false;
						break;
					default:
						Console.WriteLine("Please choose a correct option!");
						break;
				}
			}

			/*//by Rory ,me ,lina and josh

			/*Would you like to(S)tore a message or (R)etrieve a message or e(x)it ?
		   * > S
		   * What is your message ?
		   * > I am testing this message system!
		   *Saved!Your message ID is 0
		   * Would you like to(S)tore a message or(R)etriev a message ?
		   * > R
		   * What is the message ID ?
		   * > 0
		   * The message is: I am testing this message system!
		   *
		   **/
			/*  string[] message;
				message = new string[5];
				int i = 0;
				bool stop = false;
				while (stop == false)
				{
					Console.WriteLine("Would you like to (s)tore a message or (r)etrieve a message or (l)ist storage or e(x)it?");
					string response = Console.ReadLine().ToLower();
					if (response == "s")
					{
						// Saving a message
						Console.WriteLine("What is your message?");
						string message_string = Console.ReadLine();
						message[i] = Encrypter(message_string);
						Console.WriteLine("Saved! Your message ID is " + i);
						i++;
					}
					else if (response == "l")
					{
						for (i = 0; i < message.Length; i++) { Console.WriteLine(message[i]); }
					}
					else if (response == "r")
					{
						// Retrieving a message
						Console.WriteLine("What is your message id?");
						string message_id = Console.ReadLine();
						int message_id_int = Convert.ToInt32(message_id);
                        Console.WriteLine("The message is: " + Decrypter(message[message_id_int]));
					}
					else if (response == "x")
					{
						stop = true;
					}
					else
					{
						// Typed anything else
                       Console.WriteLine("I didn't understand what you typed.");
					}
				}
				Console.ReadLine();
			}
			static string Encrypter(string message)

			{
				string code = "";
				for (int i = 0; i < message.Length; i++)
				{
					int number;
					string intermediate_code = "";
					if (i % 2 == 0)
					{
						number = Convert.ToInt16(message[i]);
						number += 1;
						intermediate_code = Convert.ToString((char)number);
					}
					else
					{
						number = Convert.ToInt16(message[i]);
						number -= 1;
						intermediate_code = Convert.ToString((char)number);
					}
					code += intermediate_code;
				}
				return code;
			}
			static string Decrypter(string code)
			{
	    		string original_message = "";
				string intermediate_message;
				int number;
				for (int i = 0; i < code.Length; i++)
				{
					if (i % 2 == 0)
					{
						number = Convert.ToInt16(code[i]);
						number -= 1;
						intermediate_message = Convert.ToString((char)number);
					}
					else
					{
						number = Convert.ToInt16(code[i]);
                        number += 1;
						intermediate_message = Convert.ToString((char)number);
					}
					original_message += intermediate_message;
				}
           return original_message;*/
		}
	}
}

		/*	// this code is for sorting array !!
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
			for (int x = 0; x < 10; x++)
			{
				Console.WriteLine(inbox[x]);
			}
			/*Console.WriteLine("your array after sorting is : ");
			Array.Sort<int>(inbox);
			for (int x = 0; x < 10; x++){Console.WriteLine(inbox[x]);}*/
		/*	int d = 0;
			int test;
			while (d < 10)
			{
				for (int y = (d + 1); y < 10; y++)
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
			Console.WriteLine("your array after sorting is : ");
			for (int h = 0; h < 10; h++)
			{
				Console.WriteLine(inbox[h]);
			}

	}
	}

}*/

		
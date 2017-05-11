using System;
using System.Collections.Generic;

namespace Morse_Code
{
	class Program
{
		static void Main(string[] args)

		{

			Console.WriteLine("What is your message?");
			string message = Console.ReadLine().ToLower();

			Dictionary<char, String> morseCode = new Dictionary<char, String>()

			

			{

				{'a' , ".-"},{'b' , "-..."},{'c' , "-.-."}, //alpha
               {'d' , "-.."},{'e' , "."},{'f' , "..-."},
				{'g' , "--."},{'h' , "...."},{'i' , ".."},
				{'j' , ".---"},{'k' , "-.-"},{'l' , ".-.."},
				{'m' , "--"},{'n' , "-."},{'o' , "---"},
				{'p' , ".--."},{'q' , "--.-"},{'r' , ".-."},
				{'s' , ".-."},{'t' , "-"},{'u' , "..-"},
				{'v' , "...-"},{'w' , ".--"},{'x' , "-..-"},
				{'y' , "-.--"},{'z' , "--.."}, { ' ' , "   " },
			

                //Numbers 

                {'0' , "-----"},{'1' , ".----"},{'2' , "..----"},{'3' , "...--"},
				{'4' , "....-"},{'5' , "....."},{'6' , "-...."},{'7' , "--..."},
				{'8' , "---.."},{'9' , "----."},

			};

				string results = "";
				char c;
			//foreach (char c in message)

			for (int i = 0; i < message.Length;i++)
			{
				c = message[i];
				results += morseCode[c] + " ";
				Console.Write(results);
			}
			//Console.WriteLine(results);
			Console.ReadLine();
         }

	}

}

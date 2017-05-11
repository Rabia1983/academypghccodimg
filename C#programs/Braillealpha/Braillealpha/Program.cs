using System;
namespace Braillealpha
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string word;
			letter[] wordphrase = new letter[20];
			Console.WriteLine("enter your word!");
			word = Console.ReadLine();
			for (int i = 0; i < word.Length; i++)
			{
				letter let = new letter();
				char c = word[i];
				let.getzero();
				if (c == 'h') { let.getdot(0); let.getdot(2); let.getdot(3); wordphrase[i] = let; }
				else if (c == 'i') { let.getdot(1); let.getdot(2); wordphrase[i] = let; }
				else if (c == 'a') { let.getdot(0); wordphrase[i] = let; }
				else if (c == 'b') { let.getdot(0); let.getdot(2); wordphrase[i] = let; }
				else if (c == 'c') { let.getdot(0); let.getdot(1); wordphrase[i] = let; }
				else if (c == 'd') { let.getdot(0); let.getdot(1); let.getdot(3); wordphrase[i] = let; }
				else if (c == 'e') { let.getdot(0); let.getdot(3); wordphrase[i] = let; }
				else if (c == 'f') { let.getdot(0); let.getdot(1); let.getdot(2); wordphrase[i] = let; }
				else if (c == 'g') { let.getdot(0); let.getdot(1); let.getdot(2); let.getdot(3); wordphrase[i] = let; }
				else if (c == 'j') { let.getdot(1); let.getdot(2); let.getdot(3); wordphrase[i] = let; }
				else if (c == 'k') { let.getdot(0); let.getdot(4); wordphrase[i] = let; }
				else if (c == 'l') { let.getdot(0); let.getdot(2); let.getdot(4); wordphrase[i] = let; }
				else if (c == 'm') { let.getdot(0); let.getdot(1); let.getdot(4); wordphrase[i] = let; }
				else if (c == 'n') { let.getdot(0); let.getdot(1); let.getdot(3); let.getdot(4); wordphrase[i] = let; }
				else if (c == 'o') { let.getdot(0); let.getdot(3); let.getdot(4); wordphrase[i] = let; }
				else if (c == 'p') { let.getdot(0); let.getdot(1); let.getdot(2); let.getdot(4); wordphrase[i] = let; }
				else if (c == 'q') { let.getdot(0); let.getdot(1); let.getdot(2); let.getdot(3); let.getdot(4); wordphrase[i] = let; }
				else if (c == 'r') { let.getdot(0); let.getdot(2); let.getdot(3); let.getdot(4); wordphrase[i] = let; }
				else if (c == 's') { let.getdot(1); let.getdot(2); let.getdot(4); wordphrase[i] = let; }
				else if (c == 't') { let.getdot(1); let.getdot(2); let.getdot(3); let.getdot(4); wordphrase[i] = let; }
				else if (c == 'u') { let.getdot(0); let.getdot(4); let.getdot(5); wordphrase[i] = let; }
				else if (c == 'v') { let.getdot(0); let.getdot(2); let.getdot(4); let.getdot(5); wordphrase[i] = let; }
				else if (c == 'w') { let.getdot(1); let.getdot(2); let.getdot(3); let.getdot(5); wordphrase[i] = let; }
				else if (c == 'x') { let.getdot(0); let.getdot(1); let.getdot(4); let.getdot(5); wordphrase[i] = let; }
				else if (c == 'y') { let.getdot(0); let.getdot(1); let.getdot(3); let.getdot(4); let.getdot(5); wordphrase[i] = let; }
				else if (c == 'z') { let.getdot(0); let.getdot(3); let.getdot(4); let.getdot(5); wordphrase[i] = let; }
				else if (c == ' ') { wordphrase[i] = let; }
			}
			for (int i = 0; i < word.Length; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					Console.Write(wordphrase[i].singleletter[j]);
				}
			}
			Console.WriteLine();
			for (int i = 0; i < word.Length; i++)
			{
				for (int j = 2; j < 4; j++)
				{
					Console.Write(wordphrase[i].singleletter[j]);
				}
			}
			Console.WriteLine();
			for (int i = 0; i < word.Length; i++)
			{
				for (int j = 4; j < 6; j++)
				{
					Console.Write(wordphrase[i].singleletter[j]);
				}
			}
		}
		class letter
		{
			public string[] singleletter = new string[6];
			public void getdot(int i) { singleletter[i] = "."; }
			public void getzero()
			{
				for (int x = 0; x < singleletter.Length; x++)
					singleletter[x] = "0";
			}
		}

	}
}
// Jean's way and the handle the width of the screen!!!!

/*
 * using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Session3Scratch3

{

    class Program

    {

        static void Main(string[] args)

        {

            // set up dictionary structure with top, middle, bottom

            Dictionary<char, string[]> brailleForChar = new Dictionary<char, string[]>()

            {

                { 'b', new string[] { "10", "10", "00", "b " } },

                { 'o', new string[] { "10", "01", "10", "o " } },

                { ' ', new string[] { " ",  " ",  " ",  " "  } }

            };



            // get the string

            Console.WriteLine("Please enter some words for me to convert to Braille");

            string alphabeticInput = Console.ReadLine();



            // check the input

            bool validInput = true;

            for (int i = 0; i < alphabeticInput.Length; i++)

            {

                if(!brailleForChar.ContainsKey(alphabeticInput[i]))

                {

                    validInput = false;

                    // give feedback to user

                    Console.WriteLine("I don't know the letter " + alphabeticInput[i]);

                }

            }



            // figure out how many letters we can print on one line

            int maxWidthPerChar = 2;

            int widthInChars = Console.WindowWidth / maxWidthPerChar;

            //figure out how many lines we have to print

            //decimal outputLines = Math.Ceiling(Convert.ToDecimal(alphabeticInput.Length) / widthInChars);



            if (validInput)

            {

                // for each widthInChars chunk of the string

                while (alphabeticInput.Length > 0)

                {

                    // yank off a chunk

                    string currentChunk;

                    if (alphabeticInput.Length > widthInChars)

                    {

                        currentChunk = alphabeticInput.Substring(0, widthInChars);

                        alphabeticInput = alphabeticInput.Substring(widthInChars);

                    } else //last chunk!

                    {

                        currentChunk = alphabeticInput;

                        alphabeticInput = "";

                    }

                    // iterate through the letters in a chunk, print each line

                    int heightOfBraille = 4;

                    for (int lineNumber = 0; lineNumber < heightOfBraille; lineNumber++)

                    {

                        for (int i = 0; i < currentChunk.Length; i++)

                        {

                            Console.Write(brailleForChar[currentChunk[i]][lineNumber]);

                        }

                        // newline

                        Console.WriteLine();

                    }

                }

            } else

            {

                Console.WriteLine("Your input was invalid, I could not convert it.");

            }

            Console.ReadLine();

        }

    }

}*/
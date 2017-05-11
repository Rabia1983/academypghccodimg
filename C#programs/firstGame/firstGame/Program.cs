using System;

namespace firstGame
{
	class MainClass
{
		static void Main(string[] args)

		{
			Console.WriteLine("Hey! I'm thinking of some numbers. Can you guess one?!?! (They're between 1 and 20)");
			int[] answers = { 2, 17, 18 };
			bool gotItRight = false;

			while (gotItRight == false)
			{
				string guessAsString = Console.ReadLine();
				int guess;
				if (int.TryParse(guessAsString, out guess))
				{
					Console.WriteLine("I got your number!");
				}
				else
				{
					Console.WriteLine("Your guess must be a number. Try again.");
					continue;
				}
				for (int i = 0; i < answers.Length; i++)
				{
					if (answers[i] == guess)
					{
						gotItRight = true;
						break;
					}
				}
				if (gotItRight)
				{
					Console.WriteLine("Hey, you got it right! " + guess + " is one of my numbers! Press Enter to quit.");
				}
				else
				{
					Console.WriteLine("NOT THIS TIME. Try again.");
				}
			}
			Console.ReadLine();
          }
	}
}


                      
        



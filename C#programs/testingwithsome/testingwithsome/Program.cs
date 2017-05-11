using System;

namespace testingwithsome
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		 int[] integers =  { 1, 2, 3, 4, 5 };

			var c = new Combinations(integers, 3);

			foreach (var v in c)
			{
				System.Diagnostics.Debug.WriteLine(string.Join(",", v));
			}

			Assert.AreEqual(10, c.Count);
		}
	}
}

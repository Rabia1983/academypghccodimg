// exapmle for pattern as 1+ 1/4 +1/7 ....... and return as 0:00
/*using System;

namespace learning
{
	class MainClass
	{

		public static void Main(string[] args)
		{
			Console.WriteLine("enter your N number");
			int nn = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine(seriesSum(nn));
		}
			public static string seriesSum(int n)
		{
			string result = "";

			if (n == 0) { result = "0.00"; }
			else if (n == 1) { result = "1.00"; }
			else {

				double sum = 0.0;
				for (int i = 0; i < n; i++)
				{
					if (i == 0) { sum = 1; }
					else 
					{ sum = sum + ((double)1 / (1+(i*3)));}
				}
				result = String.Format("{0:0.00}",sum);
			
			    }
			return result;
		}}}
	
//voule count example
/*using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;
        foreach (char c in str)
        {
        if (c=='i' || c=='o' ||c=='e' ||c=='a'||c=='u')
        vowelCount += vowelCount;
        }

        return vowelCount;
    }
}*/
using System;
using System.Linq;

namespace learning
{
	class MainClass
	{

		public static void Main(string[] args)
		{
			/*	int[] arr = {50,55,57,58,60 };
				int sum = 0;
				int sum1 = 0;
				int sum2 = 0;

				for (int i = 0; i < arr.Length; i++)
				{
					for (int j = i + 2; j < arr.Length; j++)
					{
						Console.WriteLine(arr[i]);
						Console.WriteLine(arr[i+1]);
						Console.WriteLine(arr[j]);
						sum = arr[i] + arr[i + 1] + arr[j];
						Console.WriteLine(sum);
						Console.WriteLine();
						if ((arr[i+2]!=arr[j])||((arr[j] == arr[arr.Length-1])&&(arr[i + 2] != arr[j])))
						{
							Console.WriteLine(arr[i]);
							Console.WriteLine(arr[i + 2]);
							Console.WriteLine(arr[j]);
							sum1 = arr[i] + arr[i + 2] + arr[j];
							Console.WriteLine(sum1);
							Console.WriteLine();
						}
						if ((i == 0) && (j == arr.Length - 1))
						{
							Console.WriteLine(arr[i]);
							Console.WriteLine(arr[i + 3]);
							Console.WriteLine(arr[j]);
							sum2 = arr[i] + arr[i + 3] + arr[j];
							Console.WriteLine(sum2);
							Console.WriteLine();
						}

					}

				}*/

			int[] ls = { 50, 55, 57, 58, 60, 59 };
			int sum = 0;
			//int sum1 = 0;
			//int sum2 = 0;
			int k = 3;
			int o = 0;
			int t = 163;
			int[] arr = new int[20];

			while (o < 19)
			{
				for (int i = 0; i < ls.Length; i++)
				{
					for (int j = i + (k - 1); j < ls.Length; j++)
					{
						Console.WriteLine(ls[i]);
						Console.WriteLine(ls[i + 1]);
						Console.WriteLine(ls[j]);
						sum = ls[i] + ls[i + 1] + ls[j];
						Console.WriteLine(sum);
						arr[o] = sum;
						o++;
						Console.WriteLine();
						if ((ls[i + (k - 1)] != ls[j]) || ((ls[j] == ls[ls.Length - 1]) && (ls[i + (k - 1)] != ls[j])))
						{
							Console.WriteLine(ls[i]);
							Console.WriteLine(ls[i + (k - 1)]);
							Console.WriteLine(ls[j]);
							sum = ls[i] + ls[i + (k - 1)] + ls[j];
							Console.WriteLine(sum);
							arr[o] = sum;
							o++;
							Console.WriteLine();
						}
						if ((i == 0) && (j == ls.Length - 1))
						{
							for (int l = i + k; l < ls.Length; l++)
							{
								if (ls[l] != ls[j])
								{
									Console.WriteLine(ls[i]);
									Console.WriteLine(ls[l]);
									Console.WriteLine(ls[j]);
									sum = ls[i] + ls[l] + ls[j];
									Console.WriteLine(sum);
									arr[o] = sum;
									o++;
									Console.WriteLine();
								}
							}

						}
						if ((i == 0) && (j == k))
						{
							for (int a = k + 1; a < ls.Length - 1; a++)
							{
								if (ls[a] != ls[j])
								{
									Console.WriteLine(ls[i]);
									Console.WriteLine(ls[a]);
									Console.WriteLine(ls[j]);
									sum = ls[i] + ls[a] + ls[j];
									Console.WriteLine(sum);
									arr[o] = sum;
									o++;
									Console.WriteLine();
								}
							}
						}
					}
				}
			}
			Array.Sort<int>(arr);

			for (int m = 0; m < arr.Length; m++)
			{
				if (arr[m] == t)
				{
					Console.WriteLine(arr[m]);

				}

			}
		}
	}

}

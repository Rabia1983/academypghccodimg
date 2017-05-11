using System;
using System.Linq;

namespace learning
{
	class MainClass
	{

		public static void Main(string[] args)
		{
			int t = 230;
			int k =4 ;
			int[] ls = {100, 76, 56, 44, 89 ,73,68,56,64,123,2333,144,50,132,123,34,89,100};
			int i = 0;
			int count = 1;
			int[] arr = new int[100];
			while (i < ls.Length - k)
			{
					for (int j = i + 1; j <= ls.Length - (k - 1); j++)
					{
						for (int x = i + 2; x <= ls.Length - (k - 2); x++)
						{
						    int sum = 0;
							Console.WriteLine(ls[i]);
							Console.WriteLine(ls[j]);
							Console.WriteLine(ls[x]);
							sum = ls[i] + ls[j] + ls[x];
						    arr[count] = sum;
						    count++;
							Console.WriteLine(sum);

						}

					}
				i++;
			}
			Array.Sort<int>(arr);

			for (int m = 0; m < arr.Length; m++)
			{
				if (arr[m] == t)
				{
					Console.WriteLine(arr[m]);
					break;

				}
				else if ((arr[m] < t)&&(arr[m+1]>t))
				{
					Console.WriteLine(arr[m]);
					break;
				}

			}
		}
	}
}
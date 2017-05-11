using System;

namespace test
{
	class MainClass
	{
		public static void Main()
		{
			Album album = new Album();
			string tt,aa,gg,name;
			int yy,nn,len;
			Album.Trucks[] truckarray = new Album.Trucks[5];
			for (int k = 0; k < truckarray.Length; k++)
			{
				truckarray[k] = new Album.Trucks();
			}

				for (int i = 1; i < 2; i++)
			{
				Console.WriteLine("pls enter the information of your " + i + " albom" );
				Console.WriteLine("your albom title ");
				tt = Console.ReadLine();
				Console.WriteLine("your albom artist ");
				aa = Console.ReadLine();
				Console.WriteLine("your albom year ");
				yy = Convert.ToInt16(Console.ReadLine());
				Console.WriteLine("your albom genre ");
				gg = Console.ReadLine();
				Console.WriteLine("the number of tracks ");
				nn = Convert.ToInt16(Console.ReadLine());
				album.addalbum(tt,aa,yy,gg,nn);
				for (int x = 0; x < 2; x++)
				{
			 
					Console.WriteLine("enter your track name");
					name = Console.ReadLine();
					Console.WriteLine("enter your track len");
					len = Convert.ToInt16(Console.ReadLine());
					album.addtruck(name, len);

				}
				Console.WriteLine("yours "+i+" album is:");
				album.Printalbum();

			}
		}
		class Album
		{
			string title;
			string artist;
			int year;
			string genre;
			int tracksnum;
			string truckname;
			int trucklen;
			Trucks truck;


			public class Trucks
			{
				string truckname;
				int trucklen;
			}
		   

			public void addalbum(string t,string a,int y,string g,int n)
			{
				title = t;
				artist=a;
				year=y;
				genre=g;
				tracksnum = n;
			}
			public void Printalbum()
			{
				Console.WriteLine(title);
				Console.WriteLine(artist);
				Console.WriteLine(year);
				Console.WriteLine(genre);
				Console.WriteLine(tracksnum);
				for (int x = 0; x < 4; x++)
				{
					Console.WriteLine(this.truckname);
					Console.WriteLine(this.trucklen);
				}

			}
			public void addtruck(string n,int l)
			{
				this.truckname=n;
				this.trucklen=l;
			}
		

		}
	


	}
}
//john explenation
/*using System;



namespace practiceExer

{

	class MainClass

	{

		public static void Main(string[] args)

		{

			Album[] albums = new Album[10];



			for (int i = 0; i < 2; i++)

			{

				albums[i] = new Album();

				Console.WriteLine("Enter the album title, artist and release date.");

				albums[i].Title = Console.ReadLine();

				albums[i].Artist = Console.ReadLine();

				albums[i].ReleaseDate = Convert.ToInt16(Console.ReadLine());

			}



			for (int i = 0; i < 2; i++)

			{



				Console.WriteLine(albums[i].GetAlbum());

			}

		}

	}



	class Album

	{

		public string Artist;

		public string Title;

		public int ReleaseDate;



		public string GetAlbum()

		{

			return (Title + " " + Artist + " " + ReleaseDate + " ");

		}



	}

}*/

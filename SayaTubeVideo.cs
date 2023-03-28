using System;
using System.Diagnostics.Contracts;

public class SayaTubeVideo
{
	private int id;
	public string title;
	private int playCount;
	public SayaTubeVideo(string title)
	{
		Contract.Requires(title.Length < 200);
		Contract.Requires(!string.IsNullOrEmpty(title));	

		Random random= new Random();
		this.title = title;
		id = random.Next(10000, 99999);
		playCount= 0;
	}

	public void IncreasePlayCount(int playCount)
	{
		Contract.Requires(playCount < 25000000);
		Contract.Invariant(playCount >= 0);
		this.playCount = playCount;
		try
		{
			int check = checked(this.playCount + playCount);
			this.playCount = check;
		}
		catch (OverflowException overflow) 
		{
			Console.WriteLine(overflow.Message);
		}
	}

	public void PrintVideoDetails()
	{
		Console.WriteLine("Details Video : ");
		Console.WriteLine("ID : "+ id);
		Console.WriteLine("Title : "+ title);
		Console.WriteLine("Play Count : " + playCount);
		Console.WriteLine();

    }

	public int GetPlayCount()
	{
		return playCount;
	}
}

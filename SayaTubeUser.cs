using System;
using System.Diagnostics.Contracts;
using System.Reflection;

public class SayaTubeUser
{
	private int id;
	private List<SayaTubeVideo> uploadedVideos;
	public string username;
	public SayaTubeUser(string username)
	{
		Contract.Requires(username.Length <= 100);
		Contract.Requires(!string.IsNullOrEmpty(username));
		Random random= new Random();
		id = random.Next(10000, 99999);
		this.username = username;
		List<SayaTubeUser> sayaTubeUsers= new List<SayaTubeUser>();
	}

	public int GetTotalVideoPlayCount()
	{	
		int totalVideoPlayCount = 0;
		SayaTubeVideo video = null;
		Contract.Requires(video.GetPlayCount() < 2147483647);
		foreach(SayaTubeVideo sayaTubeVideo in uploadedVideos) {
			totalVideoPlayCount += video.GetPlayCount();
		}

		return totalVideoPlayCount;
	}

	public void AddVideo(SayaTubeVideo video)
	{
		Contract.Requires(video != null);
		uploadedVideos.Add(video);
	}

	public void PrintAllVideoPlayCount()
	{
		Contract.Ensures(uploadedVideos.Count <= 8);
		Console.WriteLine("User : " + username);
        for(int i = 0; i < uploadedVideos.Count; i++)
		{
			Console.WriteLine("Video " + (i+1) + "judul : "+ uploadedVideos[i].title);
		}
    }
}

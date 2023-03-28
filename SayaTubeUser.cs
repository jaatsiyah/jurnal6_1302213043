using System;
using System.Reflection;

public class SayaTubeUser
{
	private int id;
	private List<SayaTubeVideo> uploadedVideos;
	public string username;
	public SayaTubeUser(string username)
	{
		Random random= new Random();
		id = random.Next(10000, 99999);
		this.username = username;
		List<SayaTubeUser> sayaTubeUsers= new List<SayaTubeUser>();
	}

	public int GetTotalVideoPlayCount()
	{	int totalVideoPlayCount = 0;
		SayaTubeVideo video = null;
		foreach(SayaTubeVideo sayaTubeVideo in uploadedVideos) {
			totalVideoPlayCount += video.GetPlayCount();
		}

		return totalVideoPlayCount;
	}

	public void AddVideo(SayaTubeVideo video)
	{
		uploadedVideos.Add(video);
	}

	public void PrintAllVideoPlayCount()
	{
		Console.WriteLine("User : " + username);
        for(int i = 0; i < uploadedVideos.Count; i++)
		{
			Console.WriteLine("Video " + (i+1) + "judul : "+ uploadedVideos[i].title);
		}
    }
}

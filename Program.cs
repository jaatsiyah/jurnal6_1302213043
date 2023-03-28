// See https://aka.ms/new-console-template for more information
public class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo sayaTubeVideo = new SayaTubeVideo("Review Film meh oleh jaatsiyah");
        SayaTubeVideo sayaTubeVideo2 = new SayaTubeVideo("Review Film abc oleh jaatsiyah");
        SayaTubeVideo sayaTubeVideo3 = new SayaTubeVideo("Review Film cih oleh jaatsiyah");
        SayaTubeVideo sayaTubeVideo4 = new SayaTubeVideo("Review Film lalala oleh jaatsiyah");
        SayaTubeVideo sayaTubeVideo5 = new SayaTubeVideo("Review Film gtau oleh jaatsiyah");
        SayaTubeVideo sayaTubeVideo6 = new SayaTubeVideo("Review Film kekny oleh jaatsiyah");
        SayaTubeVideo sayaTubeVideo7 = new SayaTubeVideo("Review Film apa aja oleh jaatsiyah");
        SayaTubeVideo sayaTubeVideo8 = new SayaTubeVideo("Review Film iy kli oleh jaatsiyah");
        SayaTubeVideo sayaTubeVideo9 = new SayaTubeVideo("Review Film meh idk jaatsiyah");
        SayaTubeVideo sayaTubeVideo10 = new SayaTubeVideo("Review Film meh cih2 jaatsiyah");

        sayaTubeVideo.PrintVideoDetails();
        sayaTubeVideo2.PrintVideoDetails();
        sayaTubeVideo3.PrintVideoDetails();
        sayaTubeVideo4.PrintVideoDetails();
        sayaTubeVideo5.PrintVideoDetails();
        sayaTubeVideo6.PrintVideoDetails();
        sayaTubeVideo7.PrintVideoDetails();
        sayaTubeVideo8.PrintVideoDetails();
        sayaTubeVideo9.PrintVideoDetails();
        sayaTubeVideo10.PrintVideoDetails();

        SayaTubeUser sayaTubeUser = new SayaTubeUser("jaatsiyah");
        sayaTubeUser.PrintAllVideoPlayCount();

    }
}
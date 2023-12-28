class Program
{
	static void Main()
	{
		Subscriber firstSubscriber = new();
		Subscriber secondSubscriber = new();
		Subscriber thirdSubscriber = new();

		Youtuber firstYoutuber = new();

		firstYoutuber.MySubscriber += firstSubscriber.GetNotification;
		firstYoutuber.MySubscriber += secondSubscriber.GetNotification;
		firstYoutuber.MySubscriber -= secondSubscriber.GetNotification;

		firstYoutuber.UploadVideo();
	}
}

public delegate void MySubscriber(string message);

class Youtuber
{
	public event MySubscriber MySubscriber;
	public void UploadVideo()
	{
		Console.WriteLine("Uploading video...");
		Console.WriteLine("Finished....");
		SendNotification("Here is my new video");
	}
	public void SendNotification(string message)
	{
		MySubscriber.Invoke(message);
	}
}
class Subscriber
{
	public void GetNotification(string message)
	{
		Console.WriteLine("Subscriber get notified : " + message);
	}
}
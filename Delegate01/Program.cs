class Program
{
	static void Main()
	{
		Subscriber firstSubscriber = new();
		Subscriber secondSubscriber = new();
		Subscriber thirdSubscriber = new();

    Youtuber firstYoutuber = new()
    {
      MySubscriber = Subscriber.GetNotification
    };
    // firstYoutuber.MySubscriber = firstSubscriber.GetNotofication;

		firstYoutuber.UploadVideo();
	}
}

// public delegate void MySubscriber(string message);

class Youtuber
{
	// public event MySubscriber MySubscriber;
	public Action<string>? MySubscriber;
	public void UploadVideo()
	{
		Console.WriteLine("Uploading video...");
		Console.WriteLine("Finished....");
		SendNotification("Here is my new video");
	}
	public void SendNotification(string message)
	{
		MySubscriber?.Invoke(message);
	}
}
class Subscriber
{
	public static void GetNotification(string message)
	{
		Console.WriteLine("Subscriber get notified : " + message);
	}
}
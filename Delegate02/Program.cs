//Check if an instance method already registered
class Program
{
	static void Main()
	{
		Subscriber sub1 = new();
		Subscriber sub2 = new();
		Subscriber sub3 = new();

		Youtuber youtuber = new();
		Console.WriteLine(youtuber.AddSubscriber(sub1.GetNotification));
		Console.WriteLine(youtuber.AddSubscriber(sub1.GetNotification));
		Console.WriteLine(youtuber.AddSubscriber(sub3.GetNotification));
		youtuber.UploadVideo();
	}
}

public delegate void MySubscriber(string message);

class Youtuber
{
	Action<string> MySubscriber;
	public bool AddSubscriber(MySubscriber sub)
	{
		if (MySubscriber is null)
		{
			MySubscriber = sub;
			return true;
		}
		if (MySubscriber.GetInvocationList().Contains(sub))
		{
			return false;
		}
		MySubscriber += sub;
		return true;
	}
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

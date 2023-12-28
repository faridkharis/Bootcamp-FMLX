//EventHandler
// ? -> null checking
class Program
{
	static void Main()
	{
		Subscriber sub1 = new();
		Subscriber sub2 = new();
		Subscriber sub3 = new();


		Youtuber youtuber = new Youtuber("Yusuf");
		youtuber.MySubscriber += sub3.GetNotification;
		//cant use  = for event keyworded delegate
		youtuber.UploadVideo();

		Youtuber youtuber2 = new Youtuber("Yanto");
		youtuber2.MySubscriber += sub3.GetNotification;
		//cant use  = for event keyworded delegate
		youtuber2.UploadVideo();
	}
}


class Youtuber
{
	public string Name;
	public event EventHandler<MyEventArgs> MySubscriber = null!;

	public Youtuber(string name)
	{
		Name = name;
	}

	public void UploadVideo()
	{
		Console.WriteLine("Uploading video...");
		Console.WriteLine("Finished....");
		SendNotification("Here is my new video");
	}
	public void SendNotification(string message)
	{
		MySubscriber?.Invoke(this, new MyEventArgs()
		{
			dataString = message,
			dataInt = 10
		});
	}
	public override string ToString()
	{
		return Name;
	}

}

class Subscriber
{
	public void GetNotification(object sender, MyEventArgs e)
	{
		Console.WriteLine("Subscriber get notified : " + sender + ", " + e.dataString + "! " + e.dataInt);
	}
}

class MyEventArgs : EventArgs
{
	public string dataString = null!;
	public int dataInt;
}
class Program
{
	static void Main()
	{
		Subscriber firstSubscriber = new();
		Subscriber secondSubscriber = new();
		Subscriber thirdSubscriber = new();

		Youtuber firstYoutuber = new("Yusuf");
		firstYoutuber.MySubscriber += firstSubscriber.GetNotification;
		firstYoutuber.MySubscriber += secondSubscriber.GetNotification;
		firstYoutuber.MySubscriber -= secondSubscriber.GetNotification;

		// firstYoutuber.MySubscriber += new Subscriber().GetNotification;
		firstYoutuber.UploadVideo();

		Publisher firstPublisher = new("Jarot");
		firstPublisher.MySubscriber += secondSubscriber.GetNotification;
		firstPublisher.SendNotification();
	}
}

class Publisher
{
	public string Name { get; }
	public Publisher(string name)
	{
		Name = name;
	}
	public event EventHandler MySubscriber;
	public void SendNotification()
	{
		MySubscriber.Invoke(this, EventArgs.Empty);
	}
	public override string ToString() // override from class Object
	{
		return Name;
	}
}
class Youtuber
{
	public string Name { get; }
	public event EventHandler MySubscriber;
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

		MySubscriber.Invoke(this, EventArgs.Empty);
	}
	public override string ToString()
	{
		return Name;
	}
}
class Subscriber
{
	public void GetNotification(object sender, EventArgs e)
	{
		Console.WriteLine("Subscriber get notified : " + sender + " " + e);
	}
}
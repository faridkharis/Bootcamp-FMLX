// With Delegate
// Single Delegate
// Give flexibility if want to add or remove listener
// Decoupled the library with its listener
// Don't forget to make sure signature => parameter and return value must be same
class Program
{
	static void Main()
	{
		GameController game = new();
		SMS sms = new();

		game.mySubscriber = SMS.SendSMS;
		game.UpdateGameStatus();
	}
}

public delegate void MyDelegate(string message);
class GameController
{
	public MyDelegate mySubscriber;
	public GameController()
	{
	}
	public void UpdateGameStatus()
	{
		string status = "game Running";
		mySubscriber.Invoke(status);
	}
}
class SMS
{
	public static void SendSMS(string message)
	{
		Console.WriteLine("SMS " + message);
	}
}

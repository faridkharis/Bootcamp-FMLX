// With Delegate
// Must modify the library if want to add or remove listener
// Signature => parameter dan return value harus sama
// Single Delegate

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
	public void SendSMS(string message)
	{
		Console.WriteLine("SMS " + message);
	}
}
class Program
{
	static void Main()
	{
		GameController game = new GameController();
		SMS sms = new SMS();

		game.mySubscriber = sms.SendSMS;
		game.UpdateGameStatus();
	}
}
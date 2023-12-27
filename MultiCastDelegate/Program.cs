// With Delegate
// Must modify the library if want to add or remove listener
// Signature => parameter dan return value harus sama
// Multicast Delegate
// Publisher -> Subscriber
// GameController -> sms, email, database (all method that registered to delegate)

class Program
{
	static void Main()
	{
		GameController game = new();

		SMS sms = new();
		Email email = new();
		Database database = new();
		API api = new();
		Radio radio = new();

		//Register listener to the delegate
		game.mySubscriber = SMS.SendSMS;
		game.mySubscriber += Email.SendEmail;
		game.mySubscriber += API.SendApiRequest;
		game.mySubscriber += Database.InputDatabase;
		game.mySubscriber += Radio.SendRadio;

		//Invoke
		game.UpdateGameStatus();
	}
}

class GameController
{
	public MyDelegate mySubscriber;
	public GameController() { }
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
class Email
{
	public static void SendEmail(string message)
	{
		Console.WriteLine("Email " + message);
	}
}
class Database
{
	public static void InputDatabase(string message)
	{
		Console.WriteLine("Database " + message);
	}
}
class API
{
	public static void SendApiRequest(string message)
	{
		Console.WriteLine("API " + message);
	}
}
class Radio
{
	public static void SendRadio(string messaage) { }
}

public delegate void MyDelegate(string message);
// Without Delegate
// Must modify the library if want to add or remove listener
// GameController is depend on the instance (too coupled)
// It violate Open Close Principle from SOLID

class Email
{
	public void SendEmail(string message) { }
}
class Database
{
	public void InputDatabase(string message) { }
}
class API
{
	public void SendApiRequest(string message) { }
}
class UIDisplay
{
	public void Displayer(string message) { }
}

class GameController
{
	public Email email;
	public Database database;
	public API api;
	public UIDisplay uiDisplay;
	public GameController(Email email, Database database, API api, UIDisplay uiDisplay)
	{
		this.email = email;
		this.database = database;
		this.api = api;
		this.uiDisplay = uiDisplay;
	}
	public void UpdateGameStatus()
	{
		string status = "game Running";
		email.SendEmail(status);
		database.InputDatabase(status);
		api.SendApiRequest(status);
		uiDisplay.Displayer(status);
	}
}
class SMS
{
	public static void SendSMS(string message) { }
}
class Program
{
	static void Main()
	{

	}
}
class Program
{
	static void Main()
	{
		GameController gameController = new();

		Player firstPlayer = new(1, "FirstPlayerName");

		Console.WriteLine(gameController.CheckGame());

		gameController.AddPlayer(firstPlayer);

		Console.WriteLine(firstPlayer.ID);
		Console.WriteLine(firstPlayer.Name);

		Console.WriteLine(gameController.CheckGame());

		Console.WriteLine(gameController.StartGame());

	}
}

class GameController
{
	private GameStatus _gameStatus;
	private IPlayer _player;

	public GameController()
	{
		_gameStatus = GameStatus.NotInitialized;
	}

	public bool AddPlayer(IPlayer player)
	{
		if (_player is null)
		{
			return false;
		}

		if (_gameStatus is not GameStatus.NotInitialized)
		{
			return false;
		}

		_player = player;
		_gameStatus = GameStatus.Ready;

		return true;
	}

	public GameStatus CheckGame()
	{
		return _gameStatus;
	}

	public bool StartGame()
	{
		if (_gameStatus is not GameStatus.Ready)
		{
			return false;
		}

		_gameStatus = GameStatus.Playing;

		return true;
	}
}

public enum GameStatus
{
	NotInitialized,
	Ready,
	Playing,
}

public interface IPlayer
{
	public int ID { get; }
	public string Name { get; }
}

public class Player : IPlayer
{
	public int ID { get; set; }

	public string Name { get; set; }

	public Player(int ID, string Name)
	{
		this.ID = ID;
		this.Name = Name;
	}
}
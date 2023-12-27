class Program
{
	static void Main()
	{
		Player playerOne = new Player(Condition.InProgress);
		Player playerTwo = new Player(Condition.Win);

		Console.WriteLine(playerOne.condition == playerTwo.condition);
	}
}

class Player
{
	public Condition condition;
	public Player(Condition condition)
	{
		this.condition = condition;
	}
}

public enum Condition
{
	InProgress,
	Win,
	Lose
}
class Program
{
	static void Main()
	{
		Player playerOne = new(Condition.InProgress);
		Player playerTwo = new(Condition.Win);

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
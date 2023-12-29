//OK
class Program
{
	static void Main()
	{
		Human human = new("Human");
		Console.WriteLine(human.NameCounter());
	}
}

class Human
{
	private readonly string name;
	public Human(string name)
	{
		this.name = name;
	}
	public int NameCounter()
	{
		return name is not null ? name.Length : 0;
	}
}

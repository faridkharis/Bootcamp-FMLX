// Bad Code
// Use try-catch only for unhabdled case

class Program
{
	static void Main()
	{
		Human human = new();
		Console.WriteLine(human.NameCounter());
	}
}

class Human
{
	private string name = null!;
	public int NameCounter()
	{
		int count;
		try
		{
			count = name.Length;
		}
		catch (Exception e)
		{
			Console.WriteLine(e);
			count = 0;
		}

		return count;
	}
}
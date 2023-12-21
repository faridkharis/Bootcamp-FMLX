class Program
{
	static void Main()
	{
		int value = 5;
		Console.WriteLine("Initial Value: " + value);
		Multiplier(out value);
		Console.WriteLine("Final Value: " + value);
	}

	static void Multiplier(out int input)
	{
		input = 200;
	}
}
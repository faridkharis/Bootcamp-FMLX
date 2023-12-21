class Program
{
	static void Main()
	{
		int value = 5;
		Console.WriteLine("Initial Value: " + value);
		Multiplier(in value);
		Console.WriteLine("Final Value: " + value);
	}

	static void Multiplier(in int input)
	{
		int result = input + 200;
		return result;
	}
}
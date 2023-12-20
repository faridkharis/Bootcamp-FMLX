class Program
{
	public static void Main()
	{
		Calculator calc = new();
		int addResult = calc.add(1, 4, 7, 21, 67, 5);
		Console.WriteLine(addResult);

		int mulResult = calc.mul(3, 6, 4);
		Console.WriteLine(mulResult);

		decimal divResult = calc.div(9, 4);
		Console.WriteLine(divResult);
	}
}
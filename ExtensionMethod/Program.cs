class Program
{
	static void Main()
	{
		string myString = "tes";
		myString.ConsoleWriteLine();

		int myInt = 25;
		myInt.ConsoleWriteLine();
		Console.WriteLine(myInt.Dikalikan(5));

		// MyExtension.ConsoleWriteLine(10);
	}
}

public static class MyExtension
{
	public static void ConsoleWriteLine(this object myObject)
	{
		Console.WriteLine(myObject);
	}

	public static int Dikalikan(this int firstValue, int secondValue)
	{
		return firstValue * secondValue;
	}
}
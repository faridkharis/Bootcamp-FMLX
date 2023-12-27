class Program
{
	static void Main()
	{
		var day = DaysOfWeek.Monday;
		DayChecker(day);
	}

	static void DayChecker(DaysOfWeek day)
	{
		if (day == DaysOfWeek.Monday)
		{
			Console.WriteLine("Today is Monday");
		}
	}
}

public enum DaysOfWeek
{
	Monday,
	Tuesday,
	Wednesday,
	Thursday,
	Friday,
	Saturday,
	Sunday
}
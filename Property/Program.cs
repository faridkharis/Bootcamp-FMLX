class Program
{
	static void Main()
	{
		People people = new();
		Console.WriteLine(people.Name("Test"));
	}
}

class People
{
	private string _name;

	public string Name { get; set; }
}
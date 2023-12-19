public class Cat
{
	//Variable
	public string? gender;
	public int age;
	public string species;
	public string colour;

	public Cat(int age, string species, string colour)
	{
		this.age = age;
		this.species = species;
		this.colour = colour;
	}

	//Method / Function
	public void Meow(//Parameter
	)
	{
		Console.WriteLine("Meow");
	}
	public void Eat(string food)
	{
		Console.WriteLine("Eat " + food);
	}
}

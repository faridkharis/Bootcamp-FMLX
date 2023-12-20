namespace Day04;

public class Animal
{
	public string name;
	public int age;

	public Animal(string name, int age)
	{
		this.name = name;
		this.age = age;
	}

	public Animal()
	{

	}

	public string Eat(string food)
	{
		string eat = $"Eat {food}";
		return eat;
	}
}

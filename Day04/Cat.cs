namespace Day04;

public class Cat : Animal
{
	public Cat(string name, int age) : base(name, age)
	{
		this.name = name;
		this.age = age;
	}
	public string Meow()
	{
		string meow = "Meow";
		return meow;
	}
}

namespace Day04;

public class Dog : Animal
{
	public Dog(string name, int age) : base(name, age)
	{
		this.name = name;
		this.age = age;
	}
	public string Bark()
	{
		string bark = "Bark";
		return bark;
	}
}

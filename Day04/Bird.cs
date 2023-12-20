namespace Day04;

public class Bird : Animal
{
	public Bird(string name, int age) : base(name, age)
	{
		this.name = name;
		this.age = age;
	}
	public string Chirp()
	{
		string chirp = "Chrip";
		return chirp;
	}
}

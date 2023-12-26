class Program
{
	static void Main()
	{
		Animal animal = new Dog(2, "Scooby");
		animal.MakeSound();
		animal.Run();
		Console.WriteLine(animal.age);
		Console.WriteLine(animal.name);

		Dog scrapy = new(1, "Scrapy");
		scrapy.MakeSound();
		scrapy.Run();
		Console.WriteLine(scrapy.age);
		Console.WriteLine(scrapy.name);

		Console.WriteLine("Animal Object: " + animal);
		Console.WriteLine("Dog Object: " + scrapy);
	}
}

abstract class Animal
{
	public int age;
	public string name;

	public Animal(int age, string name)
	{
		this.age = age;
		this.name = name;
	}

	public abstract void MakeSound();
	public virtual void Run()
	{
		Console.WriteLine("Animal RUn");
	}
}

class Dog : Animal
{
	public Dog(int age, string name) : base(age, name)
	{

	}

	public override void MakeSound()
	{
		Console.WriteLine("Bark!");
	}

	public override void Run()
	{
		Console.WriteLine("Dog Run");
	}
}
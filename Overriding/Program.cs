class Animal
{
	public virtual void MakeSound()
	{
		Console.WriteLine("Make Sound");
	}
}

class Dog : Animal
{
	public override void MakeSound()
	{
		Console.WriteLine("Bark");
	}
}

class Program
{
	static void Main()
	{
		Dog dog = new();
		dog.MakeSound();

		Animal animal = dog;
		animal.MakeSound();

		Animal x = new Dog();
		x.MakeSound();

		int[] myArr = [1, 2, 3];

	}
}
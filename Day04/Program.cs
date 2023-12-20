namespace Day04;
public class Program
{
	static void Main()
	{
		Cat cimol = new("Cimol", 2);

		Console.WriteLine($"The cat named {cimol.name} is {cimol.age} years old. {cimol.name}'s {cimol.Meow()} indicates that he wants to {cimol.Eat("Fish")}");

		Dog scooby = new("Scooby", 4);

		Console.WriteLine($"The dog named {scooby.name} is {scooby.age} years old. {scooby.name}'s {scooby.Bark()} indicates that he wants to {scooby.Eat("Beef")}");

		Bird potty = new("Potty", 1);

		Console.WriteLine($"The bird named {potty.name} is {potty.age} years old. {potty.name}'s {potty.Chirp()} indicates that he wants to {potty.Eat("Peanuts")}");
	}
}
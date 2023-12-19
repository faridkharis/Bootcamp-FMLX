public class Program //Class //PascalCase
{
	static void Main() //Methode / Function
	{
		Cat cimol = new Cat(2, "Domestic", "White");

		Console.WriteLine($"Age : {cimol.age}");
		Console.WriteLine($"Species : {cimol.species}");
		Console.WriteLine($"Colour : {cimol.colour}");

		cimol.gender = "Male";

		Console.WriteLine($"Gender : {cimol.gender}");

		cimol.Meow();
		cimol.Eat("Fish");
	}
}

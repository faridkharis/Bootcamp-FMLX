class Program
{
	static void Main()
	{
		Car car = new(5000);

		car.GetPrice();
		// car.GetPriceStatic();
		car.GetCount();
		// car.GetCountStatic();

		Car car2 = new(7000);

		// Car.GetPrice();
		Car.GetPriceStatic();
		// Car.GetCount();
		Car.GetCountStatic();
	}
}

class Car
{
	static int count;
	int price;

	public Car(int price)
	{
		count++;
		this.price = price;
	}

	public void GetPrice()
	{
		Console.Write("GetPrice: ");
		Console.WriteLine(price);
	}

	public static void GetPriceStatic()
	{
		Console.Write("GetPriceStatic: ");
		Console.WriteLine();
		// Console.WriteLine(price);
	}

	public void GetCount()
	{
		Console.Write("GetCount: ");
		Console.WriteLine(count);
	}

	public static void GetCountStatic()
	{
		Console.Write("GetCountStatic: ");
		Console.WriteLine(count);
	}
}
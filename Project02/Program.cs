class Car
{
  public readonly int year;
  public const string brand = "Toyota";
  public Car(int year)
  {
    this.year = year;
  }
}

class Program
{
  static void Main()
  {
    Car car = new Car(2010);

    Console.WriteLine(car.year);
  }
}
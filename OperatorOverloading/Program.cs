using System.Numerics;
//Operator Overloading
public class Car : IAdditionOperators<Car, Car, Car>
{
  public int price;
  public int year;
  public string name;
  public Car(int price, int year, string name)
  {
    this.price = price;
    this.year = year;
    this.name = name;
  }
  //Operator Overloading
  public static Car operator +(Car left, Car right)
  {
    Car resultCar = new(left.price + right.price, left.year + right.year, left.name + right.name);
    return resultCar;
  }
}
class Program
{
  static void Main()
  {
    Car car = new(3000, 10, "a");
    Car carb = new(5500, 11, "b");
    Car carc = car + carb;
    Console.WriteLine(carc.price);
    Console.WriteLine(carc.year);
    Console.WriteLine(carc.name);
  }
}
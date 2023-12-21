namespace Composition;

class Program
{
  static void Main()
  {
    Engine engine = new();
    engine.cylinder = 4;
    Lamp lamp = new();
    Car car = new(engine, lamp);
    car.Start();

    ElectricEngine newEngine = new();
    Lamp newLamp = new();
    Car newCar = new(newEngine, newLamp);
    newCar.Start();
  }
}
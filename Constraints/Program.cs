using System.Numerics;
//Generic Constraint
//Generic : All class can set the type
//Constaint : Limit to a class with condition
class Calculator<T> where T : IAdditionOperators<T, T, T>
{
  public static T Addition(T a, T b)
  {
    return a + b;
  }
}
class Program
{
  static void Main()
  {
    Calculator<decimal> calculator = new();
    var result = Calculator<decimal>.Addition(3, 4);
    Console.WriteLine(result.GetType());
    Console.WriteLine(result);
  }
}
//Simple Delegate
class Program
{
  public delegate int MyDelegate(int x, int d);
  static void Main()
  {
    MyDelegate myDel = Add;
    myDel += Mul;
    int result = myDel(3, 4);
    int result2 = myDel.Invoke(3, 4);
    Console.WriteLine(result);
    Console.WriteLine(result2);
  }
  static int Add(int a, int b)
  {
    return a + b;
  }
  static int Mul(int a, int b)
  {
    return a * b;
  }
}
class Program
{
  public delegate int MyDelegate(int x, int d);
  static void Main()
  {
    MyDelegate myDel = Add;
    myDel += Mul;
    int[] myResult = new int[2];

    Delegate[] allDelegate = myDel.GetInvocationList();

    int count = 0;
    int a = 3;
    int b = 4;
    foreach (MyDelegate del in allDelegate)
    {
      myResult[count] = del.Invoke(a, b);
      count++;
    }

    Console.WriteLine(myResult);
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
public class Calculator
{
  public int add(params int[] numbers)
  {
    int result = 0;
    foreach (int number in numbers)
    {
      result += number;
    }
    return result;
  }

  public int mul(params int[] numbers)
  {
    int result = 1;
    foreach (int number in numbers)
    {
      result *= number;
    }
    return result;
  }

  public decimal div(int a, int b)
  {
    return (decimal)a / b;
  }
}
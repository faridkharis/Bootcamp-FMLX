using System.Collections;

class Program
{
	static void Main()
	{
		int[] myArray = { 1, 2, 3, 4 };
		int[] myArrayTwo = { 1, 2, 3, 4 };

		IEnumerator enumerator = myArray.GetEnumerator();

		Console.WriteLine(enumerator.MoveNext());
		Console.WriteLine(enumerator.Current);
		Console.WriteLine(enumerator.MoveNext());
		Console.WriteLine(enumerator.Current);
		Console.WriteLine(enumerator.MoveNext());
		Console.WriteLine(enumerator.Current);
		Console.WriteLine(enumerator.MoveNext());
		Console.WriteLine(enumerator.Current);
		enumerator.Reset();
		Console.WriteLine(enumerator.MoveNext());
		Console.WriteLine(enumerator.Current);
		Console.WriteLine(enumerator.GetHashCode());

		Console.WriteLine(enumerator.Equals(myArray));
		// Console.WriteLine(enumerator.Equals(myArray, myArrayTwo));
		Console.WriteLine(enumerator.GetType());

		foreach (var item in myArray)
		{
			Console.WriteLine(item);
		}
	}
}
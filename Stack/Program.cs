class Program
{
	static void Main()
	{
		Stack<int> myStack = new();

		myStack.Push(1);
		myStack.Push(2);
		myStack.Push(3);

		foreach (var item in myStack)
		{
			Console.WriteLine(item);
		}

		Console.WriteLine("myStack" + myStack);

		int result = myStack.Peek();
		Console.WriteLine(result);
	}
}
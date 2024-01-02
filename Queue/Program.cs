class Program
{
	static void Main()
	{
		Queue<int> myQueue = new();

		myQueue.Enqueue(1);
		myQueue.Enqueue(2);
		myQueue.Enqueue(3);

		foreach (var item in myQueue)
		{
			Console.WriteLine(item);
		}

		int result = myQueue.Peek();
		result = myQueue.Dequeue();
		Console.WriteLine(result);

		result = myQueue.Dequeue();
		Console.WriteLine(result);

	}
}
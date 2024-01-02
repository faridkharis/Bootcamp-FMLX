class Program
{

	static void Main()
	{
		HashSet<int> hashOne = new HashSet<int>();
		hashOne.Add(1);
		hashOne.Add(2);
		hashOne.Add(3);

		HashSet<int> hashTwo = new HashSet<int>();
		hashTwo.Add(2);
		hashTwo.Add(3);
		hashTwo.Add(4);

		hashOne.UnionWith(hashTwo);
		// hashOne.IntersectWith(hashTwo);
		// hashOne.ExceptWith(hashTwo);

		int items;
		Console.WriteLine(hashOne.TryGetValue(2, out items));

		foreach (var item in hashOne)
		{
			Console.WriteLine(item);
		}

		Console.WriteLine(hashOne.ToArray());
	}
}
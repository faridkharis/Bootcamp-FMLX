class Program
{
	static void Main()
	{
		Dictionary<int, string> myDictionary = new();
		myDictionary.Add(5, "lima");
		myDictionary.Add(2, "dua");
		myDictionary.Add(4, "empat");
		myDictionary.Add(3, "tiga");
		myDictionary.Add(1, "satu");

		// Console.WriteLine(myDictionary.Count);


		foreach (var item in myDictionary)
		{
			Console.WriteLine(item);
		}

		var sortedDictionary = myDictionary.OrderBy(pair => pair.Key);
		// Console.WriteLine(sortedDictionary);

		foreach (var item in sortedDictionary)
		{
			Console.WriteLine(item);
		}

		// foreach (var item in myDictionary.Values)
		// {
		// 	Console.WriteLine(item);
		// }

		// foreach (var item in myDictionary.Keys)
		// {
		// 	Console.WriteLine(item);
		// }
	}
}
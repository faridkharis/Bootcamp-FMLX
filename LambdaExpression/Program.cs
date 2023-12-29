class Program
{
	static void Main()
	{
		static int MyFunc(int a, int b) { return a + b; }

		Func<string, string, string> MyStringFunc = (string a, string b) => (a + b);

		Action MyAction = () => { Console.WriteLine("This is MyAnction Action"); };

		var MyAction2 = (string a) => (a);

		Console.WriteLine(MyAction2("MyAction2"));

		Console.WriteLine(MyFunc(2, 6));
		Console.WriteLine(MyStringFunc("a", "b"));
		MyAction();


	}
}
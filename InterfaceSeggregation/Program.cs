//INTERFACE SEGGREGATION PRINCIPLE
class Program
{
	static void Main()
	{
		Printer(new Printer1Juta());
		Print(new Printer150Ribu());
	}
	static void Printer(IPrinterMahal printer)
	{
		printer.Print();
		printer.Fax();
		printer.Scan();
	}
	static void Print(IPrint print)
	{
		print.Print();
	}
}

public interface IPrint
{
	void Print();
}
public interface IFax
{
	void Fax();
}
public interface IScan
{
	void Scan();
}
public interface IPrinterMahal : IPrint, IFax, IScan { }

public class Printer150Ribu : IPrint
{
	public void Print()
	{
		Console.WriteLine("Print150Ribu Grayscale B5");
	}
}
public class Printer1Juta : IPrinterMahal
{
	public void Fax()
	{
		Console.WriteLine("Printer1Juta Fax lemot");
	}

	public void Print()
	{
		Console.WriteLine("Printer1Juta Print A4 Medium Resolution");
	}

	public void Scan()
	{
		Console.WriteLine("Printer1Juta Scan low resolution");
	}
}

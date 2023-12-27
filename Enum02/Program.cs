
class Program
{
	static void Main()
	{
		int result = (int)HTTPStatus.OK;
		Console.WriteLine(result);

		HTTPStatus resultEnum = (HTTPStatus)200;
		Console.WriteLine(resultEnum);
	}
}

public enum HTTPStatus
{
	OK = 200,
	NotFound = 404,
	Redirect = 300,
	InternalServerError = 500
}
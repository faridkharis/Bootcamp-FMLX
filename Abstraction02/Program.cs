class Program
{
	static void Main()
	{
		Human human = new Human("vidya", new JogjakartaStudent());
		human.CheckHighSchool();
		human.CheckCollege();
	}
}

class Human
{
	public string Name { get; }
	private Student _student;
	public Human(String name, Student student)
	{
		Name = name;
		_student = student;
	}

	public void CheckCollege()
	{
		Console.WriteLine(_student.College());
	}
	public void CheckHighSchool()
	{
		Console.WriteLine(_student.HighSchool());
	}
}

abstract class Student
{
	public abstract string College();
	public abstract string HighSchool();
}

class JakartaStudent : Student
{
	public override string HighSchool()
	{
		return "SMAN 1 jakarta";
	}
	public override string College()
	{
		return "Binus";
	}

}
class JogjakartaStudent : Student
{
	public override string HighSchool()
	{
		return "Debritto";
	}
	public override string College()
	{
		return "UGM";
	}
}
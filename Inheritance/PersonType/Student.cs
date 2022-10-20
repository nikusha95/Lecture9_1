namespace Inheritance.PersonType;

public class Student : Person
{
    private string[] _subjects;
    public string[] Subjects => _subjects;

    public Student(string firstName, string lastName, DateTime birthDate,
        string idNumber, string[] subjects) : base(firstName, lastName, birthDate, idNumber)
    {
        _subjects = subjects;
    }

    public override void Print()
    {
        Console.WriteLine("Students info");
        base.Print();
        foreach (var subject in _subjects)
        {
            Console.WriteLine(subject);
        }
    }
}
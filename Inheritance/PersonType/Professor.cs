namespace Inheritance.PersonType;

public class Professor : Person
{
    private readonly string _subject;

    public Professor(string firstName, string lastName, DateTime birthDate, string idNumber, string subject)
        : base(firstName, lastName, birthDate, idNumber)
    {
        _subject = subject;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"subject: {_subject}");
    }
}
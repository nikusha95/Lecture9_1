using System.Runtime.InteropServices;
using System.Security.Principal;

namespace Inheritance.PersonType;

public class Person
{
    protected string _firstName;
    protected string _lastName;
    protected string _idNumber;
    protected DateTime _birthDate;

    public string FirstName => _firstName;
    public string LastName => _lastName;

    public Person(string firstName, string lastName, DateTime birthDate, string idNumber)
    {
        _firstName = firstName;
        _lastName = lastName;
        _birthDate = birthDate;
        _idNumber = idNumber;
    }

    public virtual void Print()
    {
        Console.WriteLine($"Person info:{_firstName} {_lastName} {_birthDate:yyyy-MM-dd} {_idNumber}");
    }
}
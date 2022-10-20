// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using Inheritance;
using Inheritance.PersonType;

//Shape s = new(0, 0);

//s.Print();

//Console.WriteLine(s.ToString());

//Circle c1 = new(1, 1, 5);
//c1.Print();
//Console.WriteLine(c1.ToString());

Person person = new("person1", "lastname1", new DateTime(1992, 12, 12),
    "123456789012");
person.Print();

Student student = new("person2", "lastname2",
    new DateTime(1992, 12, 12),
    "11111111111", new[] { "Math", "C#", "Javascript" });
student.Print();

Person pTransformed = student;
pTransformed.Print();

Person pk = (Person)student;
pk.Print();

Person person2 = new Student("person2", "lastname2",
    new DateTime(1992, 12, 12),
    "11111111111", new[] { "Math", "C#", "Javascript" });

person2.Print();


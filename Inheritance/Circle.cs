namespace Inheritance;

public class Circle : Shape //x-->circle-->shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public Circle(int x, int y, double radius) : base(x, y)
    {
        // this.x = x;
        // this.y = y;
        this.radius = radius;
        Console.WriteLine("Circle Constructor");
    }

    public double Perimeter()
    {
        return 2 * Math.PI * radius;
    }

    public override string ToString()
    {
        return $"{base.ToString()} radius:{radius}";
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"radius:{radius}");
    }
}
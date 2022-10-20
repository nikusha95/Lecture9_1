namespace Inheritance;

public class Shape //sealed  - cannot be inherited
{
    protected int x;
    protected int y;

    public Shape()
    {
    }

    public Shape(int x, int y)
    {
        this.x = x;
        this.y = y;
        Console.WriteLine("Shape Constructor");
    }

    public override string ToString()
    {
        return $"x:{x} y:{y}";
    }
    public virtual void Print()
    {
        Console.WriteLine($"x:{x} y:{y}");
    }
}
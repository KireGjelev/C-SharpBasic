
namespace Task01.Models;
public class Circle : Shape
{
    public int radius;

    public Circle(string name, string color, int[] position, int radius)
        : base(name, color, position)
    {
        this.radius = radius;
    }

    public override void getArea()
    {
        Console.WriteLine($"Area of {Name} is {Math.PI * radius * radius}.");
    }

    public override void getPerimeter()
    {
        Console.WriteLine($"Perimeter of {Name} is {2 * Math.PI * radius}.");
    }
}
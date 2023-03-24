
namespace Task01.Models;
public class Rectangle : Shape
{
    public int sideA;
    public int sideB;

    public Rectangle(string name, string color, int[] position, int sideA, int sideB)
        : base(name, color, position)
    {
        this.sideA = sideA;
        this.sideB = sideB;
    }

    public override void getArea()
    {
        Console.WriteLine($"Area of {Name} is {sideA * sideB}.");
    }

    public override void getPerimeter()
    {
        Console.WriteLine($"Perimeter of {Name} is {(sideA + sideB) * 2}.");
    }
}
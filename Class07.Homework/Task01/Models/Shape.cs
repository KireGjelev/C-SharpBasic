
namespace Task01.Models;
public class Shape
{
    public string name;
    public string color;
    public int[] position;

    public Shape(string name, string color, int[] position)
    {
        this.name = name;
        this.color = color;
        this.position = position;
    }

    public string Name
    {
        get { return name; }
        set
        {
            Console.WriteLine($"Changing name of {name} to {value}.");
            name = value;
        }
    }

    public string Color
    {
        get { return color; }
        set
        {
            if (value.Length < 3)
            {
                Console.WriteLine("Color must be at least 3 characters long.");
            }
            else
            {
                Console.WriteLine($"Changing color of {name} to {value}.");
                color = value;
            }
        }
    }

    public int[] Position
    {
        get { return position; }
    }

    public void move()
    {
        Console.WriteLine($"Moving {name} by 5 units.");
        position[0] += 5;
        position[1] += 5;
    }

    public virtual void getArea()
    {
        Console.WriteLine("There is no special implementation for area.");
    }

    public virtual void getPerimeter()
    {
        Console.WriteLine("There is no special implementation for perimeter.");
    }
}
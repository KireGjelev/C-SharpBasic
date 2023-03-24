
using Task01.Models;

int[] pos1 = { 0, 0 };
Rectangle rect1 = new Rectangle("Rect1", "Red", pos1, 4, 5);
rect1.Color = "Blue";
Console.WriteLine("Rect1's name is: " + rect1.Name); 
Console.WriteLine("Rect1's color is: " + rect1.Color); 

int[] pos2 = { 10, 10 };
Circle circle1 = new Circle("Circle1", "Green", pos2, 3);
circle1.Name = "NewCircle"; 
circle1.Color = "Yellow";
Console.WriteLine("Circle1's name is: " + circle1.Name); 
Console.WriteLine("Circle1's color is: " + circle1.Color); 
    
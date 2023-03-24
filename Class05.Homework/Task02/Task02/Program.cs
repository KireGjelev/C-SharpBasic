
using Task02;

Dog myDog = new Dog();

Console.Write("Enter the dog's name: ");
myDog.Name = Console.ReadLine();
Console.Write("Enter the dog's breed: ");
myDog.Breed = Console.ReadLine();
Console.Write("Enter the dog's color: ");
myDog.Color = Console.ReadLine();


Console.WriteLine("Your dog is:");
Console.WriteLine("- Name: " + myDog.Name);
Console.WriteLine("- Breed: " + myDog.Breed);
Console.WriteLine("- Color: " + myDog.Color);


Console.WriteLine("Choose an action for your dog:");
Console.WriteLine("1. Eat");
Console.WriteLine("2. Play");
Console.WriteLine("3. Chase tail");
Console.Write("Enter your choice: ");
int choice = int.Parse(Console.ReadLine());


switch (choice)
{
    case 1:
        myDog.Eat();
        break;
    case 2:
        myDog.Play();
        break;
    case 3:
        myDog.ChaseTail();
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}
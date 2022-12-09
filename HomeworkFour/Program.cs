//Welcome message
Console.WriteLine("Homework Four");
Console.WriteLine("-------------");

//Get user input
Console.Write("Enter your first name: ");
string? name = Console.ReadLine();

Console.Write("How about your age? ");
int.TryParse(Console.ReadLine(), out int age);

//Show result
Console.WriteLine();
switch (name?.ToLower())
{
	case "bob" or "sue":
		Console.WriteLine($"Hi Professor {name}!");
		break;
	default:
		Console.WriteLine($"Hello {name}!");
		break;
}

if (age < 21)
{
	Console.WriteLine($"Recommending you to wait {21-age} year(s) before to start the class.");
}

Console.ReadLine();
//Welcome message
Console.WriteLine("Homework Three with Switch Statement");
Console.WriteLine("------------------------------------");
Console.WriteLine();

//Get user input
Console.Write("What is your name: ");
string? name = Console.ReadLine();

//Process result
Console.WriteLine();
switch (name?.ToLower())
{
	case "tim" or "timothy":
		Console.WriteLine($"Welcome Professor {name}");
		break;
	default:
		Console.WriteLine($"Welcome Student {name}");
		break;
}

Console.ReadLine();
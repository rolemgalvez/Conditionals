//Welcome message
Console.WriteLine("Homework Three with If Statement");
Console.WriteLine("--------------------------------");
Console.WriteLine();

//Get user input
Console.Write("What is your name: ");
string? name = Console.ReadLine();

//Process results
Console.WriteLine();
if (name?.ToLower() == "tim" || name?.ToLower() == "timothy")
{
    Console.WriteLine($"Welcome Professor {name}");
}
else
{
    Console.WriteLine($"Welcome Student {name}");
}

Console.ReadLine();
//Welcome message
Console.WriteLine("Medical Cash Allowance");
Console.WriteLine("For Employee's Dependents");
Console.WriteLine("-------------------------");

//Get user input
Console.Write("When do you want to receive the allowance, (1) per Semester or (2) per Month? ");
int.TryParse(Console.ReadLine(), out int frequency);

//Process input
switch (frequency)
{
	case 1:
		Console.WriteLine("Php 1,500 is the maximum amount you can expect every semester.");
		break;
	case 2:
		Console.WriteLine("Php 250 is the maximum amount you can expect every month.");
		break;
	default:
		Console.WriteLine("Enter only 1 or 2 as your answer.");
		break;
}

Console.ReadLine();
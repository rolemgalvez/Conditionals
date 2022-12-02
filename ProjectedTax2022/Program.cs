//Welcome message
Console.WriteLine("Projected Tax 2022");
Console.WriteLine("------------------");
Console.WriteLine();

//Get user input
Console.Write("What is your expected annual salary: ");
bool isNumber = double.TryParse(Console.ReadLine(), out double annualSalary);

//Show results
Console.WriteLine();
double annualTax = double.NaN;

switch (annualSalary)
{
	case > 250000 and <= 400000:
		annualTax = 0.20 * (annualSalary - 250000);
		break;
	case > 400000 and <= 800000:
		annualTax = 30000 + (0.25 * (annualSalary - 400000));
		break;
	case > 800000 and <= 2000000:
		annualTax = 130000 + (0.30 + (annualSalary - 800000));
		break;
	case > 2000000 and <= 8000000:
		annualTax = 490000 + (0.32 + (annualSalary - 2000000));
		break;
	case > 8000000:
		annualTax = 2400000 + (0.35 + (annualSalary - 8000000));
		break;
	default:
		Console.WriteLine("You are exempted to Tax Deduction.");
		break;
}

if (double.IsNaN(annualSalary) == false)
{
	Console.WriteLine("Your Projected Witholding Tax is as follows...");
	Console.WriteLine($"For Semi-Monthly: {annualTax / 12 / 2}");
	Console.WriteLine($"For Monthly     : {annualTax / 12}");
	Console.WriteLine($"For Yearly      : {annualTax}");
}

Console.ReadLine();
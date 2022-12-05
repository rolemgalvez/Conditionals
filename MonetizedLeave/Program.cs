//Welcome message
Console.WriteLine("Monetized Leave");
Console.WriteLine("---------------");
Console.WriteLine();

//Get user input
Console.Write("What type of an employee are you, private or government? ");
string? employeeType = Console.ReadLine();
double leaveCredit = double.NaN;

if (employeeType.ToLower() == "private")
{
    Console.Write("How many unused Vacation Leave credits do you have? ");
}
else if (employeeType.ToLower() == "government")
{
    Console.Write("How many monetized Vacation & Sick Leave credits do you have? ");
}
double.TryParse(Console.ReadLine(), out leaveCredit);

//Process input
bool acceptableEmployeeType = (employeeType.ToLower() == "private") || 
                              (employeeType.ToLower() == "government");
double taxable = 0;
double nonTaxable = 10;

if (acceptableEmployeeType && double.IsNaN(leaveCredit) == false)
{
    switch (employeeType.ToLower())
    {
        case "private":
            if (leaveCredit > 10)
            {
                taxable = leaveCredit - 10;
            }
            else
            {
                nonTaxable = leaveCredit;
            }
            break;
        case "government":
            nonTaxable = leaveCredit;
            break;
        default:
            break;
    }

    Console.WriteLine($"Your {nonTaxable} leave credit(s) is Non-Taxable.");
    if (taxable > 0)
    {
        Console.WriteLine($"While the {taxable} leave credit(s) is Taxable.");
    }
}
else
{
    Console.WriteLine("Double check your given input and try again.");
}

Console.ReadLine();
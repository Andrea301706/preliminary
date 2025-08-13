
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter time of day (AM/PM): ");
        string timeOfDay = Console.ReadLine().ToUpper();

        Console.Write("Enter day of the week: ");
        string dayOfWeek = Console.ReadLine();

        int ticketPrice = 0;

        // Base price based on age
        if (age < 13)
        {
            ticketPrice = 150; // Child
        }
        else if (age >= 60)
        {
            ticketPrice = 120; // Senior
        }
        else
        {
            ticketPrice = 200; // Adult
        }

        // Add ₱50 for PM
        if (timeOfDay == "PM")
        {
            ticketPrice += 50;
        }

        // Add ₱30 for weekends
        string day = dayOfWeek.ToLower();
        if (day == "saturday" || day == "sunday")
        {
            ticketPrice += 30;
        }

        Console.WriteLine("Your total ticket price is: ₱" + ticketPrice);
    


Console.WriteLine("Pick a snack (1–4):");
Console.WriteLine("1. Popcorn");
Console.WriteLine("2. Soda");
Console.WriteLine("3. Nachos");
Console.WriteLine("4. Candy");

Console.Write("Enter your choice: ");
int choice;

if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
{
    Console.WriteLine("Invalid input! Please enter a number between 1 and 4.");
    return;
}

switch (choice)
{
    case 1:
        Console.WriteLine("Popcorn - Price: ₱80, Calories: 250 kcal");
        break;
    case 2:
        Console.WriteLine("Soda - Price: ₱50, Calories: 150 kcal");
        break;
    case 3:
        Console.WriteLine("Nachos - Price: ₱120, Calories: 370 kcal");
        break;
    case 4:
        Console.WriteLine("Candy - Price: ₱30, Calories: 120 kcal");
        break;
}

Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine());

Console.Write("Do you have parental consent? (yes/no): ");
string consent = Console.ReadLine().ToLower();

Console.Write("Do you have an ID? (yes/no): ");
string hasID = Console.ReadLine().ToLower();

if (age >= 18)
{
    if (hasID == "yes")
    {
        Console.WriteLine("Allowed");
    }
    else
    {
        Console.WriteLine("Not allowed");
    }
}
else // under 18
{
    if (consent == "yes" && hasID == "yes")
    {
    
        Console.WriteLine("Allowed with guardian");
    }
    else
    {
        Console.WriteLine("Not allowed");
    }
}

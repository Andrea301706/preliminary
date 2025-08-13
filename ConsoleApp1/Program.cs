
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
    

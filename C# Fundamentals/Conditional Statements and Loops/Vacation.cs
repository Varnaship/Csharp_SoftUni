int people =int.Parse(Console.ReadLine());  
string type = Console.ReadLine();   
string day = Console.ReadLine();
decimal pricePerPerson = 0;
if (type == "Students")
{
    if (day == "Friday")
    {
        pricePerPerson = 8.45m;
        if (people >= 30)
        {
            pricePerPerson *= 0.85m;
            Console.WriteLine($"Total price: {(people * pricePerPerson):F2}");
        }
        else
        {
            Console.WriteLine($"Total price: {(people * pricePerPerson):F2}");
        }
    }
    if (day == "Saturday")
    {
        pricePerPerson = 9.80m;
        if (people >= 30)
        {
            pricePerPerson *= 0.85m;
            Console.WriteLine($"Total price: {(people * pricePerPerson):F2}");
        }
        else
        {
            Console.WriteLine($"Total price: {(people * pricePerPerson):F2}");
        }
    }
    if (day == "Sunday")
    {
        pricePerPerson = 10.46m;
        if (people >= 30)
        {
            pricePerPerson *= 0.85m;
            Console.WriteLine($"Total price: {(people * pricePerPerson):F2}");
        }
        else
        {
            Console.WriteLine($"Total price: {(people * pricePerPerson):F2}");
        }
    }
}
else if (type == "Business")
{
    if (day == "Friday")
    {
        pricePerPerson = 10.90m;
        if (people >= 100)
        {
           
            Console.WriteLine($"Total price: {(people * pricePerPerson - pricePerPerson * 10):F2}");
        }
        else
        {
            Console.WriteLine($"Total price: {(people * pricePerPerson):F2}");
        }
    }
    if (day == "Saturday")
    {
        pricePerPerson = 15.60m;
        if (people >= 100)
        {
            
            Console.WriteLine($"Total price: {(people * pricePerPerson-pricePerPerson*10):F2}");
        }
        else
        {
            Console.WriteLine($"Total price: {(people * pricePerPerson):F2}");
        }
    }
    if (day == "Sunday")
    {
        pricePerPerson = 16m;
        if (people >= 100)
        {
                
            Console.WriteLine($"Total price: {(people * pricePerPerson - pricePerPerson * 10):F2}");
        }
        else
        {
            Console.WriteLine($"Total price: {(people * pricePerPerson):F2}");
        }
    }
}
else if (type == "Regular")
{
    if (day == "Friday")
    {
        pricePerPerson = 15m;
        if (people >= 10 && people <=20)
        {
            pricePerPerson *= 0.05m;
            Console.WriteLine($"Total price: {(people * pricePerPerson):F2}");
        }
        else
        {
            Console.WriteLine($"Total price: {(people * pricePerPerson):F2}");
        }
    }
    if (day == "Saturday")
    {
        pricePerPerson = 20m;
        if (people >= 10 && people <= 20)
        {
            pricePerPerson *= 0.05m;
            Console.WriteLine($"Total price: {(people * pricePerPerson):F2}");
        }
        else
        {
            Console.WriteLine($"Total price: {(people * pricePerPerson):F2}");
        }
    }
    if (day == "Sunday")
    {
        pricePerPerson = 22.50m;
        if (people >= 10 && people <= 20)
        {
            pricePerPerson *= 0.05m;
            Console.WriteLine($"Total price: {(people * pricePerPerson):F2}");
        }
        else
        {
            Console.WriteLine($"Total price: {(people * pricePerPerson):F2}");
        }
    }
}
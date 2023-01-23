decimal sum = 0m;
while(true)
{
    string input = Console.ReadLine();
	
    if (input=="Start")
	{
		break;
    }
    
    decimal coin = decimal.Parse(input);    
    
    if (coin==0.1m || coin==0.2m || coin==0.5m || coin==1m || coin==2m )
    {
        sum+= coin;
    }
    
    else
    {
        Console.WriteLine($"Cannot accept {coin}");
    }
}
while(true)
{
    string input = Console.ReadLine();
    
    if (input == "End")
    {
        break;
    }

    switch (input)
    {
        case "Nuts":
            if (sum < 2.0m)
            {
                Console.WriteLine("Sorry, not enough money");
                break;
            }
            sum -= 2.0m;
            Console.WriteLine($"Purchased nuts");
            break;
        case "Water":
            if (sum < 0.7m)
            {
                Console.WriteLine("Sorry, not enough money");
                break;
            }
            sum -= 0.7m;
            Console.WriteLine($"Purchased water");
         
            break;
        case "Crisps":
            if (sum < 1.5m)
            {
                Console.WriteLine("Sorry, not enough money");
                break;
            }
            sum -= 1.5m;
            Console.WriteLine($"Purchased crisps");
       
            break;
        case "Soda":

            if (sum < 0.8m)
            {
                Console.WriteLine("Sorry, not enough money");
                break;
            }
            sum -= 0.8m;
            Console.WriteLine($"Purchased soda");
         
            break;
        case "Coke":
            if (sum < 1.0m)
            {
                Console.WriteLine("Sorry, not enough money");
                break;
            }
            sum -= 1.0m;
            Console.WriteLine($"Purchased coke");
       
            break;
        default:
            Console.WriteLine("Invalid product");
            break;
    }
   
}
Console.WriteLine($"Change: {sum:F2}");
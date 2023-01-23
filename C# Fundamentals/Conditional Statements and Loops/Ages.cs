string input = Console.ReadLine();
int.TryParse(input, out int age);
if (age >= 0 && age < 3)
{
    Console.WriteLine("baby");
}

else if (age > 2 && age < 14)
{
    Console.WriteLine("child");
}

else if (age > 13 && age < 20)
{
    Console.WriteLine("teenager");
}

else if (age > 19 && age < 66)
{
    Console.WriteLine("adult");
}

else if (age > 65)
{
    Console.WriteLine("elder");
}
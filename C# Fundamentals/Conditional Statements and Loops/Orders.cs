int orders = int.Parse(Console.ReadLine());
double price = 0.0;
double totalPrice = 0.0;
for (int i = 0;i < orders; i++)
{
    double pricePerCapsule = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsulesCount = int.Parse(Console.ReadLine());
    price = ((days * capsulesCount) * pricePerCapsule);
    Console.WriteLine($"The price for the coffee is: ${price:F2}");
    totalPrice+= price;
}
Console.WriteLine($"Total: ${totalPrice:F2}");
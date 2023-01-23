int capacity  =  int.Parse(Console.ReadLine());
int daysCounter = 0;
int extractedResource = 0;
while (capacity >= 100)
{  
    extractedResource+= capacity-26;
    capacity -= 10;
    daysCounter++;
}
if (daysCounter > 0 )
{
    extractedResource -= 26;
}
Console.WriteLine(daysCounter);
Console.WriteLine(extractedResource);
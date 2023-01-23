int numberOfLines = int.Parse(Console.ReadLine());
int capacity = 255;
int sum = 0;
for (int i = 0;i < numberOfLines; i++)
{
    
	int line = int.Parse(Console.ReadLine());
	if (line>capacity)
	{
		Console.WriteLine("Insufficient capacity!");
	}
	else
	{
		sum+= line;
		capacity-= line;
	}
}
Console.WriteLine(sum);
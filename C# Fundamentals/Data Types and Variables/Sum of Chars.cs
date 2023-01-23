int rows = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0;i < rows; i++)
{
    char input = Convert.ToChar(Console.ReadLine());
    sum += input;
}
Console.WriteLine($"The sum equals: {sum}");
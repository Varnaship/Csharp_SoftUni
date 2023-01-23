int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());
for (int i = start; i <= end; i++)
{
    char number = Convert.ToChar(i);
    Console.Write($"{number} ");
}
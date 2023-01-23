int number = int.Parse(Console.ReadLine());
int copyNumber = number;
int sum = 0;
while (copyNumber > 0)
{
    int digit = copyNumber% 10;
    copyNumber= copyNumber / 10;
    int factoriel = 1;
    for (int i = 1; i <= digit; i++)
    {
        factoriel*= i;
    }
    sum+= factoriel;
}
if (sum == number)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}

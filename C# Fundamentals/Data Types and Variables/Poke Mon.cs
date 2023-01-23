int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int copyOfN = n;
int defeatedEnemies = 0;
double half = (double)n * 0.50;
while(n>=m)
{
    defeatedEnemies++;
    n -= m;

    if (n == half  && y!=0)
    {
        n /= y; 
    }   
}
Console.WriteLine(n);
Console.WriteLine(defeatedEnemies);
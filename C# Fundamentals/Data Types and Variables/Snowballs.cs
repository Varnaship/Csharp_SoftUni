using System.Numerics;

int snowballs = int.Parse(Console.ReadLine());
int bestSnow = 0;
int bestTime = 0;
int bestQuality = 0;
BigInteger maxValue = 0;

for(int i = 0;i < snowballs; i++)
{
    int snowballSnow = int.Parse(Console.ReadLine());
    int snowballTime = int.Parse(Console.ReadLine());
    int snowballQuality = int.Parse(Console.ReadLine());

    BigInteger value = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

    if (value > maxValue)
    {
        maxValue = value;
        bestSnow = snowballSnow;
        bestTime = snowballTime;    
        bestQuality = snowballQuality; 
    }
}
Console.WriteLine($"{bestSnow} : {bestTime} = {maxValue} ({bestQuality})");
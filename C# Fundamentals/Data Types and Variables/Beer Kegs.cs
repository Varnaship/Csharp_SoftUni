int n  =  int.Parse(Console.ReadLine());
string model = Console.ReadLine();
float radius = float.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
string biggestModel = model;
double maxVolume = Math.Pow(radius,2) * height* Math.PI;
for (int i = 1;i < n; i++)
{
    model = Console.ReadLine();
    radius = float.Parse(Console.ReadLine());
    height = int.Parse(Console.ReadLine());
    double currentVolume = Math.Pow(radius, 2) * height * Math.PI;
    if (currentVolume>maxVolume)
    {
        maxVolume= currentVolume;
        biggestModel= model;
    }
}
Console.WriteLine(biggestModel);
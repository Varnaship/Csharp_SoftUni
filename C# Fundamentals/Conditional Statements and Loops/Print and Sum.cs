int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = 0;  
for(int i = a;i<= b;i++)
{
    Console.Write($"{i} ");
    c += i;
}   
Console.WriteLine($"\n Sum: {c}");    
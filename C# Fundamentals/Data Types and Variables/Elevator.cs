int pasengers = int.Parse(Console.ReadLine());
int capacity = int.Parse(Console.ReadLine());
if (pasengers%capacity==0)
{
    Console.WriteLine(pasengers / capacity);
}
else
{
    Console.WriteLine(pasengers / capacity+1);
}
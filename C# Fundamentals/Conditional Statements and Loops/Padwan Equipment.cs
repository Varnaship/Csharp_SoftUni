double budget = double.Parse(Console.ReadLine());
int students = int.Parse(Console.ReadLine());
double lightsaberPrice = double.Parse(Console.ReadLine()); 
double robesPrice = double.Parse(Console.ReadLine());
double beltsPrice = double.Parse(Console.ReadLine());
int freebelts = 0;
if (students>=6)
{
    freebelts++;
    if(students-6>=6)
    {
        freebelts += (students - 6) / 6;
    }
}
double neededSum=lightsaberPrice*Math.Ceiling(students+students*0.1)+beltsPrice*(students-freebelts)+robesPrice*students;
if (neededSum>budget)
{
    Console.WriteLine($" John will need {(neededSum-budget):f2}lv more.");
}
else
{
    Console.WriteLine($"The money is enough - it would cost {neededSum:F2}lv.");
}
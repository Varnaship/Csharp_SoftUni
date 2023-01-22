const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";
Console.WriteLine("Choose [r]ock, [p]aper, [s]cissors: ");
string playerMove = Console.ReadLine();
Random random = new Random();
int pcRandomNumber = random.Next(1,4);
string pcMove = "";
switch(pcRandomNumber)
{
    case 1:
        pcMove= Rock;
        break;
    case 2:
        pcMove= Paper;
        break;
    case 3:
        pcMove = Scissors;
        break;
}
if (playerMove == "r" || playerMove == "rock") 
{
    playerMove = Rock;
}
else if (playerMove == "p" || playerMove == "paper") 
{
    playerMove = Paper;
}
else if (playerMove == "s" || playerMove == "scissors")
{
    playerMove = Scissors;
}
else
{
    Console.WriteLine("Invalid input. Try again...");
    return;
}
Console.WriteLine($"The computer chose {pcMove}.");
if ((playerMove == Rock && pcMove == Scissors)||
    (playerMove == Paper && pcMove == Rock)||
    (playerMove == Scissors && pcMove == Paper))
{
    Console.WriteLine("You win!");
}
else if (playerMove == pcMove)
{
    Console.WriteLine("This game was a draw...");
}
else
{
    Console.WriteLine("You lose.");
}

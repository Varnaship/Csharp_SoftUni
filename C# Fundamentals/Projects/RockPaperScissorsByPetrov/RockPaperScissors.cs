const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Choose [r]ock, [p]aper, [s]cissors: ");
Console.WriteLine("The winner will be picked after best of 5");
Console.ResetColor();
string pcMove = "";
int pcWins = 0;
int playerWins = 0;
int playedGames = 1;
bool correctInput = true;
while (playedGames <=5)
{
    if (correctInput = true)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"This is game number {playedGames} ");
        Console.ResetColor();
    }

    string playerMove = Console.ReadLine();
    Random random = new Random();
    int pcRandomNumber = random.Next(1, 4);
    switch (pcRandomNumber)
    {
        case 1:
            pcMove = Rock;
            break;
        case 2:
            pcMove = Paper;
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
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid input. Try again...");
        correctInput = false;
        Console.ResetColor();
    }
    if (correctInput == true)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"The computer choose {pcMove}.");
        Console.ResetColor();
        correctInput = true;
        if ((playerMove == Rock && pcMove == Scissors) ||
        (playerMove == Paper && pcMove == Rock) ||
        (playerMove == Scissors && pcMove == Paper))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You win this round. ");
            Console.ResetColor();
            playerWins++;
            correctInput = true;
        }
        else if (playerMove == pcMove)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("This round was a draw...");
            Console.ResetColor();
            correctInput = true;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You lost this round.");
            Console.ResetColor();
            pcWins++;
            correctInput = true;
        }
        playedGames++;
        if (playedGames <= 5)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Choose [r]ock, [p]aper, [s]cissors: ");
            Console.ResetColor();
        }
    }
}
if (pcWins>playerWins)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("The computer won the match :(");
    Console.ResetColor();
}
else if(playerWins>pcWins)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("You won the match!!!");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("The battle was so balanced that there is no winner.... ");
    Console.ResetColor();
}

string username = Console.ReadLine();
string password = new string(username.Reverse().ToArray());
int logins = 0;
while(true)
{
    string providedPassword = Console.ReadLine();
	if (providedPassword==password)
	{
		Console.WriteLine($"User {username} logged in.");
		break;
	}
	else 
	{
		Console.WriteLine("Incorrect password. Try again.");
		logins++;	
    }
	if (logins==3)
	{
		Console.WriteLine($"User {username} blocked!"); 
        break;
	}
}
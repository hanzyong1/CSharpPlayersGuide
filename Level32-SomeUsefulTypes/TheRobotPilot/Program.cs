int rangeOfManticoreFromTheCity;
int cityFullHealth = 15;
int cityCurrentHealth = 15;
int manticoreFullHealth = 10;
int manticoreCurrentHealth = 10;
int currentRound = 1;

int getRangeOfManticoreFromTheCity()
{
    Random rand = new Random();
    return rand.Next(101);
}

int getCannonTargetRange()
{
    Console.Write("Enter desired cannon range: ");
    return Convert.ToInt32(Console.ReadLine());
}

int getCannonDamage(int roundNumber)
{
    if (roundNumber % 3 == 0 && roundNumber % 5 == 0)
    {
        return 10;
    }
    else if (roundNumber % 3 == 0)
    {
        return 3;
    }
    else if (roundNumber % 5 == 0)
    {
        return 3;
    }
    else
    {
        return 1;
    }
}

void getResultOfCannonShot()
{
    int cannonTargetRange = getCannonTargetRange();
    if (cannonTargetRange > rangeOfManticoreFromTheCity)
    {
        cityCurrentHealth -= 1;
        Console.WriteLine("That round OVERSHOT the target.");
    }
    else if (cannonTargetRange < rangeOfManticoreFromTheCity)
    {
        cityCurrentHealth -= 1;
        Console.WriteLine("That round FELL SHORT the target.");
    }
    else
    {
        cityCurrentHealth -= 1;
        manticoreCurrentHealth -= 1;
        Console.WriteLine("That round was a DIRECT HIT!");
    }
}

void playRound()
{
    Console.WriteLine("---------------------------------------------------");
    Console.WriteLine($"STATUS: Round: {currentRound} City: {cityCurrentHealth}/{cityFullHealth} Manticore: {manticoreCurrentHealth}/{manticoreFullHealth}");
    Console.WriteLine($"The cannon is expected to deal {getCannonDamage(currentRound)} damage this round.");
    getResultOfCannonShot();
    currentRound += 1;
}

rangeOfManticoreFromTheCity = getRangeOfManticoreFromTheCity();
Console.Clear();
Console.WriteLine("Player, it is your turn.");
while (true)
{
    playRound();
    if (cityCurrentHealth <= 0)
    {
        Console.WriteLine("The city of Consolas has been destroyed!");
        return;
    }
    else if (manticoreCurrentHealth <= 0)
    {
        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
        return;
    }
}
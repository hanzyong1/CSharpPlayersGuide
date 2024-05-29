int pilotNumber = -1;

while (pilotNumber < 0 || pilotNumber > 100)
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    pilotNumber = Convert.ToInt32(Console.ReadLine());

    Console.Clear();   
};

Console.WriteLine("User 2, guess the number.");
int hunterNumber = 0;

while (hunterNumber != pilotNumber)
{
    Console.Write("What is your next guess? ");
    hunterNumber = Convert.ToInt32(Console.ReadLine());

    if (hunterNumber > pilotNumber)
    {
        Console.WriteLine($"{hunterNumber} is too high.");
    }
    else if (hunterNumber < pilotNumber)
    {
        Console.WriteLine($"{hunterNumber} is too low");
    }
    else
    {
        Console.WriteLine("You guessed the number!");
    }
}
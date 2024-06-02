State currentState = State.Locked;

void manipulateChest(string input)
{
    if (currentState == State.Open && input == "close")
    {
        currentState = State.Closed;
    }
    else if (currentState == State.Closed && input == "lock") 
    {
        currentState = State.Locked;
    }
    else if (currentState == State.Closed && input == "open")
    {
        currentState = State.Open;
    }
    else if (currentState == State.Locked && input == "unlock")
    {
        currentState = State.Closed;
    }
    else
    {
        return;
    }
}

while (true)
{
    Console.Write($"The chest is {currentState}. What do you want to do? ");
    string input = Console.ReadLine();
    manipulateChest(input);
}

enum State
{
    Locked,
    Open,
    Closed,
}
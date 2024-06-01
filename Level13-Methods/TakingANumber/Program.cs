int AskForNumber(string text)
{
    Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        int num = AskForNumber(text);
        if (num > min && num < max)
        {
            return num;
        }
    }
}

AskForNumberInRange("input number", 1, 10);
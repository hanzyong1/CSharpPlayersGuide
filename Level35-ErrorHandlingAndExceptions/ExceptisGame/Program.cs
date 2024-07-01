try
{
    int answer = new Random().Next(10);
    List<int> previousGuesses = new List<int>();

    while (true)
    {
        int input;
        bool previouslyGuessed;

        do
        {
            Console.WriteLine("Pick a number between 0 and 9 (inclusive)");
            input = Convert.ToInt32(Console.ReadLine());
            previouslyGuessed = previousGuesses.Contains(input);
            if (previouslyGuessed)
            {
                Console.WriteLine("That number has been guessed before.");
            }
        } 
        while (previouslyGuessed);

        if (input == answer)
        {
            throw new Exception();
        }

        previousGuesses.Add(input);
    }
}
catch
{
    Console.WriteLine("That was a bad number! You lose!");
}
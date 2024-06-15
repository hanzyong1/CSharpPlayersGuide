PasswordValidator passwordValidator = new PasswordValidator();

while (true)
{
    Console.WriteLine("Please enter a password: ");
    string input = Console.ReadLine();
    passwordValidator.Validate(input);
    Console.WriteLine();
}

public class PasswordValidator
{
    public bool Validate(string input)
    {
        if (!CheckLength(input))
        {
            return false;
        }
        
        if (!CheckUpperLowerDigit(input))
        {
            return false; 
        }

        if (!ValidateSpecial(input))
        {
            return false;
        }

        Console.WriteLine("Password is allowed.");
        return true;
    }

    public bool CheckLength(string input)
    {
        if (input.Length > 6 && input.Length <= 13)
        {
            return true;
        }
        else
        {
            Console.WriteLine("Password is not allowed.");
            Console.WriteLine("Password must be at least 6 letters long and no more than 13 letters long.");
            return false;
        }
    }

    public bool CheckUpperLowerDigit(string input)
    {
        int upperCount = 0;
        int lowerCount = 0;
        int digitCount = 0;

        foreach (char c in input) 
        {
            if (char.IsUpper(c))
            {
                upperCount++;
            }
            else if (char.IsLower(c)) 
            {
                lowerCount++;
            }
            else if (char.IsDigit(c))
            {
                digitCount++;
            }
        }

        if (upperCount == 0 || lowerCount == 0 || digitCount == 0)
        {
            Console.WriteLine("Password is not allowed.");
            Console.WriteLine("Password must contain at least one uppercase letter, one lowercase letter, and one number.");
            return false;
        }
        else
        {
            return true;
        }
    }

    public bool ValidateSpecial(string input)
    {
        foreach (char c in input)
        {
            if (c.Equals('T') || c.Equals('&'))
            {
                Console.WriteLine("Password is not allowed.");
                Console.WriteLine("Password cannot contain a capital T or an ampersand.");
                return false;
            }
        }
        return true;
    }
}
Console.Write("What is your passcode for your door? ");
int input = Convert.ToInt32(Console.ReadLine());
Door door = new Door(input);

while (true)
{
    Console.WriteLine($"The door is currently {door.Status}.");
    Console.WriteLine("What do you want to do? (open, close, lock, unlock, change passcode)");
    string action = Console.ReadLine();
    Console.WriteLine();

    switch (action)
    {
        case "open":
            door.OpenDoor(); 
            break;
        case "close":
            door.CloseDoor();
            break;
        case "lock":
            door.LockDoor();
            break;
        case "unlock":
            door.UnlockDoor();
            break;
        case "change passcode":
            door.ChangePasscode();
            break;
        default:
            continue;
    }
}

public class Door
{
    public DoorState Status { get; private set; } = DoorState.Locked;
    private int Passcode;

    public Door(int passcode)
    {
        Passcode = passcode;
    }

    public void CloseDoor()
    {
        if (Status == DoorState.Open)
        {
            Console.WriteLine("The door is closed");
            Status = DoorState.Closed;
        }
        else
        {
            Console.WriteLine("This action can only be performed when the door is opened.");
            return;
        }
    }

    public void OpenDoor()
    {
        if (Status == DoorState.Closed)
        {
            Console.WriteLine("The door is opened.");
            Status = DoorState.Open;
        }
        else
        {
            {
                Console.WriteLine("This action can only be performed when the door is closed and unlocked.");
                return;
            }
        }
    }

    public void LockDoor()
    {
        if (Status == DoorState.Closed)
        {
            Console.WriteLine("The door is locked.");
            Status = DoorState.Locked;
        }
        else
        {
            Console.WriteLine("This action can only be performed when the door is closed and unlocked.");
            return;
        }
    }

    public void UnlockDoor()
    {
        if (Status == DoorState.Locked)
        {
            Console.Write("Please enter your passcode: ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == Passcode)
            {
                Console.WriteLine("Door unlocked.");
                Status = DoorState.Closed;
            } 
            else
            {
                Console.WriteLine("Passcode is incorrect.");
                return;
            }
        }
        else
        {
            Console.WriteLine("This action can only be performed when the door is closed and locked.");
            return;
        }
    }

    public void ChangePasscode()
    {
        Console.WriteLine("Please enter your old passcode: ");
        int oldPasscode = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Please enter your new passcode: ");
        int newPasscode = Convert.ToInt32(Console.ReadLine());

        if (Passcode == oldPasscode)
        {
            Passcode = newPasscode;
            Console.WriteLine("Passcode successfully changed.");
            return;
        }
        else
        {
            Console.WriteLine("Wrong passcode.");
            return;
        }
    }
}

public enum DoorState
{
    Open,
    Closed,
    Locked,
}
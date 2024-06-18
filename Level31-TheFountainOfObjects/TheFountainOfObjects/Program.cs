World world = new World();
world.InitialiseWorld(4, 4);

while (true)
{
    Console.WriteLine("----------------------------");
    Console.WriteLine($"You are in the room at ({world})");
    world.RoomState();
    if (!world.GameState) {
        Console.Write("What do you want to do? ");
        string choice = Console.ReadLine();
        world.PlayerMove(choice);
    }
    else
    {
        Console.WriteLine("You win!");
        break;
    }
    
}

public class World
{
    public int Row { get; private set; }
    public int Column { get; private set; }
    public Room[,] Rooms { get; private set; }
    public bool FountainEnabled { get; private set; } = false;
    public bool GameState { get; private set; } = false;


    public void InitialiseWorld(int numRows, int numCols)
    {
        Rooms = new Room[numRows, numCols];

        for (int row = 0; row < Rooms.GetLength(0); row++)
        {
            for (int column = 0; column < Rooms.GetLength(1); column++)
            {
                if (row == 0 && column == 0)
                {
                    Rooms[row, column] = new Room(true, false);
                } 
                else if (row == 0 && column == 2)
                {
                    Rooms[row, column] = new Room(false, true);
                }
                else
                {
                    Rooms[row, column] = new Room();
                }
                
            }
        }
    }
    public void RoomState()
    {
        if (Row == 0 && Column == 0 && !FountainEnabled)
        {
            Console.WriteLine("You see light coming from the cavern entrance.");
        }
        else if (Row == 0 && Column == 0 && FountainEnabled)
        {
            GameState = true;
            Console.WriteLine("The Fountain of Objects has been reactivated, and you have escaped with your life!");
        }
        else if (Row == 0 && Column == 2 && !FountainEnabled)
        {
            Console.WriteLine("You hear water dripping in this room. The Fountain of Objects is here!");
        }
        else if (Row == 0 && Column == 2 && FountainEnabled)
        {
            Console.WriteLine("You hear the rushing waters from the Fountain of Objects. It has been reactivated!");
        }
        else
        {
            return;
        }
    }
    public void EnableFountain(Room room)
    {
        if (room.HasFountain)
        {
            FountainEnabled = true;
        } 
        
    }
    public void DisableFountain(Room room)
    {
        if (room.HasFountain)
        {
            FountainEnabled = false;
        }
        
    }
    public bool PlayerMove(string input)
    {
        int newRow = Row;
        int newColumn = Column;

        switch (input) 
        {
            case "move north":
                newRow++;
                break;
            case "move south":
                newRow--;
                break;
            case "move east":
                newColumn++;
                break;
            case "move west":
                newColumn--;
                break;
            case "enable fountain":
                EnableFountain(Rooms[Row, Column]);
                break;
            case "disable west":
                DisableFountain(Rooms[Row, Column]);
                break;
        }

        if (newRow >= 0 && newRow < Rooms.GetLength(0) && newColumn >= 0 && newColumn < Rooms.GetLength(1))
        {
            Column = newColumn;
            Row = newRow;
            return true;
        }

        return false;
    }
    public override string ToString()
    {
        return $"Row={Row}, Column={Column}";
    }
}

public class Room
{
    public bool IsEntrance { get; } = false;
    public bool HasFountain { get; } = false;

    public Room()
    {
    }

    public Room(bool isEntrance, bool hasFountain)
    {
        IsEntrance = isEntrance;
        HasFountain = hasFountain;
    }
}
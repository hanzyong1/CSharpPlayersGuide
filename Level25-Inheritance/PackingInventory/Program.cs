Pack pack = new Pack(3, 10.0, 10.0);

while (true)
{
    Console.WriteLine();

    pack.GetInfo();
    Console.WriteLine("What would you like to add? ");
    Console.WriteLine("1 - Arrow");
    Console.WriteLine("2 - Bow");
    Console.WriteLine("3 - Rope");
    Console.WriteLine("4 - Water");
    Console.WriteLine("5 - Food");
    Console.WriteLine("6 - Sword");
    int choice = Convert.ToInt32(Console.ReadLine());

    InventoryItem item = choice switch
    {
        1 => new Rope(),
        2 => new Bow(),
        3 => new Rope(),
        4 => new Water(),
        5 => new Food(),
        6 => new Sword(),
    };

    if (pack.Add(item))
    {
        Console.WriteLine("Item added.");
    }
    else
    {
        Console.WriteLine("Exceeded pack limits.");
        continue;
    }
}


public class Pack
{
    public int TotalNumberOfItems { get; }
    public double MaxWeight { get; }
    public double MaxVolume { get; }
    public int CurrentNumberOfItems { get; private set; }
    public double CurrentWeight { get; private set; }
    public double CurrentVolume { get; private set; }
    public InventoryItem[] ItemList { get; private set; }
    
    public Pack(int totalNumberOfItems, double maxWeight, double maxVolume)
    {
        TotalNumberOfItems = totalNumberOfItems;
        MaxWeight = maxWeight;
        MaxVolume = maxVolume;
        ItemList = new InventoryItem[totalNumberOfItems];
    }

    public bool Add(InventoryItem item)
    {
        if (CurrentNumberOfItems == TotalNumberOfItems || CurrentWeight + item.Weight > MaxWeight || CurrentVolume + item.Volume > MaxVolume)
        {
            return false;
        }
        else
        {
            ItemList[CurrentNumberOfItems] = item;

            CurrentNumberOfItems++;
            CurrentWeight += item.Weight;
            CurrentVolume += item.Volume;

            return true;
        }
    }

    public void GetInfo()
    {
        Console.WriteLine($"Current item count: {CurrentNumberOfItems}. Item limit: {TotalNumberOfItems}.");
        Console.WriteLine($"Current weight: {CurrentWeight}. Weight limit: {MaxWeight}.");
        Console.WriteLine($"Current volume: {CurrentVolume}. Volume limit: {MaxVolume}.");
    }
}

public class InventoryItem
{
    public double Weight { get; }
    public double Volume { get; }

    public InventoryItem(double weight, double volume)
    {
        Weight = weight;
        Volume = volume;
    }
}

public class Arrow : InventoryItem
{
    public Arrow() : base(0.1, 0.05) 
    {
    }
}

public class Bow : InventoryItem
{
    public Bow() : base(1, 4)
    {
    }
}

public class Rope : InventoryItem
{
    public Rope() : base(1, 1.5)
    {
    }
}

public class Water : InventoryItem
{
    public Water() : base(2, 3)
    {
    }
}

public class Food : InventoryItem
{
    public Food() : base(1, 0.5)
    {
    }
}

public class Sword : InventoryItem
{
    public Sword() : base(5, 3)
    {
    }
}
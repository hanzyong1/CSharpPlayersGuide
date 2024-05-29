Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");

Console.Write("What number do you want to see the price of? ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("What is your name? ");
string name = Console.ReadLine();

string item = num switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipement",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies"
};

int price = item switch
{
    "Rope" => 10,
    "Torches" => 15,
    "Climbing Equipment" => 25,
    "Clean Water" => 1,
    "Machete" => 20,
    "Canoe" => 200,
    "Food Supplies" => 1,
};

if (name == "me")
{
    price /= 2;
};

Console.WriteLine($"{item} costs {price}");
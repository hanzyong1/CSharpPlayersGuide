Arrow arrow = GetArrow();
Console.WriteLine($"The arrow costs {arrow.GetCost()} gold");

Arrow GetArrow()
{
    Arrowhead arrowhead = GetArrowheadType();
    Fletching fletching = GetFletchingType();
    float shaftLength = GetShaftLength();
    return new Arrow(arrowhead, shaftLength, fletching);
}

Arrowhead GetArrowheadType()
{
    Console.WriteLine("Choose arrowhead type (steel, wood, obsidian): ");
    string input = Console.ReadLine();
    return input switch
    {
        "steel" => Arrowhead.Steel,
        "wood" => Arrowhead.Wood,
        "obsidian" => Arrowhead.Obsidian,
    };
}

Fletching GetFletchingType()
{
    Console.WriteLine("Choose fletching type (plastic, turkey feathers, goose feathers): ");
    string input = Console.ReadLine();
    return input switch
    {
        "plastic" => Fletching.Plastic,
        "turkey feathers" => Fletching.TurkeyFeathers,
        "goose feathers" => Fletching.GooseFeathers,
    };
}

float GetShaftLength()
{
    float length = 0;
    while (length < 60 || length > 100)
    {
        Console.WriteLine("Choose shaft length (between 60 and 100 cm long): ");
        length = Convert.ToSingle(Console.ReadLine());
    }
    return length;
}

class Arrow
{
    public Arrowhead Arrowhead { get; }
    public float Shaft { get; }
    public Fletching Fletching { get; }


    public Arrow(Arrowhead arrowhead, float shaft, Fletching fletching)
    {
        Arrowhead = arrowhead;
        Shaft = shaft;
        Fletching = fletching;
    }

    public float GetCost()
    {
        float arrowheadCost = Arrowhead switch
        {
            Arrowhead.Steel => 10,
            Arrowhead.Wood => 3,
            Arrowhead.Obsidian => 5,
        };

        float fletchingCost = Fletching switch
        {
            Fletching.Plastic => 10,
            Fletching.TurkeyFeathers => 5,
            Fletching.GooseFeathers => 3,
        };

        float shaftPrice = (float)(Shaft * 0.05);

        return arrowheadCost + fletchingCost + shaftPrice;
    }
}

enum Arrowhead
{
    Steel,
    Wood,
    Obsidian
}

enum Fletching
{
    Plastic,
    TurkeyFeathers,
    GooseFeathers
}
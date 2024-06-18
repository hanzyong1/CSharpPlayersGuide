Sword original = new Sword(Material.Iron, Gemstone.None, 10, 5);
Sword fancy = original with { Material = Material.Binarium, Gemstone = Gemstone.Diamond };
Sword ultralong = original with { Material = Material.Binarium, Gemstone = Gemstone.Sapphire, Length = 15 };

Console.WriteLine(original);
Console.WriteLine(fancy);
Console.WriteLine(ultralong);

public record Sword(Material Material, Gemstone Gemstone, float Length, float Width);

public enum Material
{
    Wood,
    Bronze,
    Iron,
    Steel,
    Binarium,
}

public enum Gemstone
{
    Emerald,
    Amber,
    Sapphire,
    Diamond,
    Bitstone,
    None,
}
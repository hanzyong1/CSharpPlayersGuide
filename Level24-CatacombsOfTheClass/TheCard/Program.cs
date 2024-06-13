Color[] colors = new Color[] { Color.Red, Color.Green, Color.Blue, Color.Yellow };
Rank[] ranks = new Rank[] { Rank.One, Rank.Two, Rank.Three, Rank.Four, Rank.Five, Rank.Six, Rank.Seven, Rank.Eight, Rank.Nine, Rank.Ten, Rank.Dollar, Rank.Percent, Rank.Caret, Rank.Ampersand };

foreach (Color color in colors)
{
    foreach (Rank rank in ranks)
    {
        Card card = new Card(color, rank);
        Console.WriteLine($"The {card.Color} {card.Rank}");
    }
}

public class Card
{
    public Color Color { get; }
    public Rank Rank { get; }

    public Card(Color color, Rank rank)
    {
        Color = color;
        Rank = rank;
    }

    public bool isNumber => !isSymbol;
    public bool isSymbol => (Rank == Rank.Dollar || Rank == Rank.Percent || Rank == Rank.Caret || Rank == Rank.Ampersand);
}

public enum Color
{
    Red,
    Green,
    Blue,
    Yellow,
}

public enum Rank
{
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Dollar,
    Percent,
    Caret,
    Ampersand,
}
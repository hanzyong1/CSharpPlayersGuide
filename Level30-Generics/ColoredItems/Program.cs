ColoredItem<Sword> sword = new ColoredItem<Sword>(new Sword(), ConsoleColor.Blue);
ColoredItem<Bow> bow = new ColoredItem<Bow>(new Bow(), ConsoleColor.Red);
ColoredItem<Axe> axe = new ColoredItem<Axe>(new Axe(), ConsoleColor.Green);

sword.Display();
bow.Display();
axe.Display();

public class Sword { }
public class Bow { }
public class Axe { }

public class ColoredItem<T>
{
    public T Item { get; set; }
    public ConsoleColor ConsoleColor { get; }

    public ColoredItem(T item, ConsoleColor color) 
    {
        Item = item;
        ConsoleColor = color;
    }

    public void Display()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        return $"A {ConsoleColor} {Item}";
    }
}
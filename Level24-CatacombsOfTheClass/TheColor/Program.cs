Color custom = new Color(1, 1, 1);
Color white = Color.White;

Console.WriteLine($"({custom.R}, {custom.G}, {custom.B})");
Console.WriteLine($"({white.R}, {white.G}, {white.B})");

public class Color
{
    public int R { get; }
    public int G { get; }
    public int B { get; }

    public Color(int red, int green, int blue)
    {
        R = red;
        G = green;
        B = blue;
    }

    public static Color White = new Color(255, 255, 255);
    public static Color Black = new Color(0, 0, 0);
    public static Color Red = new Color(255, 0, 0);
    public static Color Orange = new Color(255, 165, 0);
    public static Color Yellow = new Color(255, 255, 0);
    public static Color Green = new Color(0, 128, 0);
    public static Color Blue = new Color(0, 0, 255);
    public static Color Purple = new Color(128, 0, 128);
}
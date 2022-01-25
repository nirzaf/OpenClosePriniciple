namespace OpenClosePrinciple;

public class Product
{
    public readonly Color Color;
    public readonly string Name;
    public readonly Size Size;

    public Product(string name, Color color, Size size)
    {
        Name = name;
        Color = color;
        Size = size;
    }
}
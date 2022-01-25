namespace OpenClosePrinciple;

public class Product
{
    private readonly Color _color;
    private readonly string _name;
    private readonly Size _size;

    public Product(string name, Color color, Size size)
    {
        _name = name;
        _color = color;
        _size = size;
    }

    public Color Color()
    {
        return _color;
    }

    public Size Size()
    {
        return _size;
    }

    public string Name()
    {
        return _name;
    }
}
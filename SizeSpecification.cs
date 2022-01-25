namespace OpenClosePrinciple;

public class SizeSpecification : ISpecification<Product>
{
    private readonly Size _size;

    public SizeSpecification(Size size)
    {
        _size = size;
    }

    public bool IsSatisfied(Product p)
    {
        return p.Size == _size;
    }
}
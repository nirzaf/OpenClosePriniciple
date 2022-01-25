public class SizeSpecification : ISpecification<Product>
{
    private Size _size;

    public SizeSpecification(Size size)
    {
        this._size = size;
    }

    public bool IsSatisfied(Product p)
    {
        return p.Size == _size;
    }
}
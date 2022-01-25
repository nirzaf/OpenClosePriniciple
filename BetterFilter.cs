namespace OpenClosePrinciple;

public class BetterFilter : IFilter<Product>
{
    public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
    {
        return items.Where(spec.IsSatisfied);
    }
}
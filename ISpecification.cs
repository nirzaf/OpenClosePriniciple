namespace OpenClosePrinciple;

public interface ISpecification<T>
{
    bool IsSatisfied(Product p);
}
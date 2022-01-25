public interface ISpecification<T>
{
    bool IsSatisfied(Product p);
}
namespace VeelenSoft.Validation.Specifications
{
    public interface IObjectSpecification<in T> : ISpecification
    {
        bool IsSatisfiedBy(T subject);
    }
}

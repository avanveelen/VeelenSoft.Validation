namespace VeelenSoft.Validation.Specifications
{
    public interface IPropertySpecification<in TProperty> : ISpecification
    {
        bool IsSatisfiedBy(TProperty property);
    }
}
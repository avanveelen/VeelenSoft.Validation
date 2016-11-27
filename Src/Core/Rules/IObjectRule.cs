using VeelenSoft.Validation.Specifications;

namespace VeelenSoft.Validation.Rules
{
    public interface IObjectRule<T> : IRule<T>
    {
        IObjectSpecification<T> ObjectSpecification { get; set; }
    }
}
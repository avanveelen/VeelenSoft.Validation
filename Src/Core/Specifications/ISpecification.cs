using VeelenSoft.Validation.ValidationMessages;

namespace VeelenSoft.Validation.Specifications
{
    public interface ISpecification
    {
        ValidationMessage DefaultValidationMessage { get; }
    }
}
using VeelenSoft.Validation.Filters;
using VeelenSoft.Validation.ValidationMessages;

namespace VeelenSoft.Validation.Rules
{
    public interface IRule<T> : IFilteredRule<T>
    {
        bool IsValid(T subject);

        ValidationMessage ValidationMessage { get; set; }
    }
}
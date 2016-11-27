using System.Collections.Generic;
using System.Threading.Tasks;
using VeelenSoft.Validation.Rules;

namespace VeelenSoft.Validation.Validators
{
    public interface IValidator<T>
    {
        ValidationResult Validate(T subject);

        Task<ValidationResult> ValidateAsync(T subject);
        
        List<IRule<T>> Rules { get; }
    }
}
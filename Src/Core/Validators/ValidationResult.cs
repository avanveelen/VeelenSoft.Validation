using System.Collections.Generic;
using System.Linq;
using VeelenSoft.Validation.ValidationMessages;

namespace VeelenSoft.Validation.Validators
{
    public class ValidationResult
    {
        public ValidationResult(IReadOnlyList<ValidationMessage> validationMessages)
        {
            ValidationMessages = validationMessages;
        }

        public bool IsValid => !this.ValidationMessages.Any();

        public IReadOnlyList<ValidationMessage> ValidationMessages { get; }
    }
}

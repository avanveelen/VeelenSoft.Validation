using System;
using VeelenSoft.Validation.ValidationMessages;

namespace VeelenSoft.Validation.Specifications
{
    public class StringNotNullOrWhiteSpace : IPropertySpecification<string>
    {
        public bool IsSatisfiedBy(string property)
        {
            return !string.IsNullOrWhiteSpace(property);
        }

        public ValidationMessage DefaultValidationMessage => new ValidationMessage("string can not be null or empty.");
    }
}
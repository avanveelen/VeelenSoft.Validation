using System;
using VeelenSoft.Validation.ValidationMessages;

namespace VeelenSoft.Validation.Specifications
{
    public class DateNotInThePast : IPropertySpecification<DateTime>
    {
        public bool IsSatisfiedBy(DateTime property)
        {
            return property >= DateTime.Now;
        }

        public ValidationMessage DefaultValidationMessage { get; }
    }
}
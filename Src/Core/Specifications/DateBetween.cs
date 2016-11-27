using System;
using VeelenSoft.Validation.ValidationMessages;

namespace VeelenSoft.Validation.Specifications
{
    public class DateBetween : IPropertySpecification<DateTime>
    {
        private readonly DateTime _value1;
        private readonly DateTime _value2;

        public DateBetween(DateTime value1, DateTime value2)
        {
            this._value1 = value1;
            this._value2 = value2;
        }

        public bool IsSatisfiedBy(DateTime property)
        {
            return property >= this._value1 && property <= this._value2;
        }


        public ValidationMessage DefaultValidationMessage { get; }
    }
}
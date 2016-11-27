using System;
using System.Collections.Generic;
using System.Linq;
using VeelenSoft.Validation.Filters;
using VeelenSoft.Validation.Specifications;
using VeelenSoft.Validation.ValidationMessages;

namespace VeelenSoft.Validation.Rules
{
    public class PropertyRule<T, TProperty> : IPropertyRule<T, TProperty>
    {
        public PropertyRule(Func<T, TProperty> property)
        {
            Property = property;
            this.Specifications = new List<IPropertySpecification<TProperty>>();
            this.Filters = new List<IFilter<T>>();
        }

        public bool IsValid(T subject)
        {
            if (Filters.All(f => f.IsFiltered(subject)))
            {
                return true;
            }

            return this.Specifications.All(s => s.IsSatisfiedBy(this.Property(subject)));
        }

        public ValidationMessage ValidationMessage { get; set; }

        public Func<T, TProperty> Property { get; }

        public IList<IPropertySpecification<TProperty>> Specifications { get; set; }

        public IList<IFilter<T>> Filters { get; }
    }
}

using System.Collections.Generic;
using System.Linq;
using VeelenSoft.Validation.Filters;
using VeelenSoft.Validation.Specifications;
using VeelenSoft.Validation.ValidationMessages;

namespace VeelenSoft.Validation.Rules
{
    public class Rule<T> : IObjectRule<T>
    {
        public Rule()
        {
            this.Filters = new List<IFilter<T>>();
        }

        public IObjectSpecification<T> ObjectSpecification { get; set; }

        public ValidationMessage ValidationMessage { get; set; }

        public bool IsValid(T subject)
        {
            if (Filters.All(f => f.IsFiltered(subject)))
            {
                return true;
            }

            return ObjectSpecification.IsSatisfiedBy(subject);
        }

        public IList<IFilter<T>> Filters { get; }
    }
}
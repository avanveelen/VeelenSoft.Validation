using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeelenSoft.Validation.Rules;

namespace VeelenSoft.Validation.Validators
{
    public abstract class Validator<T> : IValidator<T>
    {
        protected Validator()
        {
            this.Rules = new List<IRule<T>>();    
        }

        public ValidationResult Validate(T subject)
        {
            return new ValidationResult(this.Rules.Where(r => !r.IsValid(subject)).Select(r => r.ValidationMessage).ToList());
        }

        public Task<ValidationResult> ValidateAsync(T subject)
        {
            throw new NotImplementedException();
        }

        protected IObjectRule<T> Rule()
        {
            var rule = new Rule<T>();
            this.Rules.Add(rule);
            return rule;
        }
        
        protected IPropertyRule<T, TProperty> RuleFor<TProperty>(Func<T, TProperty> property)
        {
            var rule = new PropertyRule<T, TProperty>(property);
            this.Rules.Add(rule);
            return rule;
        }

        public List<IRule<T>> Rules { get; }
    }
}

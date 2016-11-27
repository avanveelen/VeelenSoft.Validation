using System;
using VeelenSoft.Validation.Rules;

namespace VeelenSoft.Validation.Specifications
{
    public static class Extensions
    {
        public static IRule<T> Should<T>(this IObjectRule<T> rule, IObjectSpecification<T> objectSpecification)
        {
            rule.ObjectSpecification = objectSpecification;
            return rule;
        }

        public static IPropertyRule<T, string> IsNotEmpty<T>(this IPropertyRule<T, string> rule)
        {
            rule.Specifications.Add(new StringNotNullOrWhiteSpace());
            return rule;
        }

        public static IPropertyRule<T, DateTime> IsNotInThePast<T>(this IPropertyRule<T, DateTime> rule)
        {
            rule.Specifications.Add(new DateNotInThePast());
            return rule;
        }

        public static IPropertyRule<T, DateTime> Between<T>(this IPropertyRule<T, DateTime> rule, DateTime value1,
            DateTime value2)
        {
            rule.Specifications.Add(new DateBetween(value1, value2));
            return rule;
        }
    }
}
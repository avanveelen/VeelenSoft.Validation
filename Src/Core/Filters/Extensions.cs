using System;
using System.Linq.Expressions;
using VeelenSoft.Validation.Rules;

namespace VeelenSoft.Validation.Filters
{
    public static class Extensions
    {
        public static IFilteredRule<T> When<T>(this IRule<T> rule, Expression<Func<T, bool>> filter)
        {
            var inversedFilter = Expression.Lambda<Func<T, bool>>(Expression.Not(filter.Body), filter.Parameters);
            rule.Filters.Add(new Filter<T>(inversedFilter.Compile()));
            return rule;
        }

        public static IFilteredRule<T> And<T>(this IFilteredRule<T> rule, Expression<Func<T, bool>> filter)
        {
            var inversedFilter = Expression.Lambda<Func<T, bool>>(Expression.Not(filter.Body), filter.Parameters);
            rule.Filters.Add(new Filter<T>(inversedFilter.Compile()));
            return rule;
        }

        public static IFilteredRule<T> ExceptWhen<T>(this IRule<T> rule, Expression<Func<T, bool>> filter)
        {
            rule.Filters.Add(new Filter<T>(filter.Compile()));
            return rule;
        }
    }
}
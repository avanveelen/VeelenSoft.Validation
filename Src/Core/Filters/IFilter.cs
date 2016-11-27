using System;
using System.Linq.Expressions;

namespace VeelenSoft.Validation.Filters
{
    public interface IFilter<T>
    {
        Func<T, bool> IsFiltered { get; } 
    }
}
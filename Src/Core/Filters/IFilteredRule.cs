using System.Collections;
using System.Collections.Generic;

namespace VeelenSoft.Validation.Filters
{
    public interface IFilteredRule<T>
    {
        IList<IFilter<T>> Filters { get; }
    }
}
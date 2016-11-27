using System;

namespace VeelenSoft.Validation.Filters
{
    public class Filter<T> : IFilter<T>
    {
        internal Filter(Func<T, bool> isFiltered)
        {
            IsFiltered = isFiltered;
        }

        public Func<T, bool> IsFiltered { get; private set; }
    }
}
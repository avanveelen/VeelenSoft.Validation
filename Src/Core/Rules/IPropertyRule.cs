using System;
using System.Collections.Generic;
using VeelenSoft.Validation.Specifications;

namespace VeelenSoft.Validation.Rules
{
    public interface IPropertyRule<T, TProperty> : IRule<T>
    {
        Func<T,TProperty> Property { get; }

        IList<IPropertySpecification<TProperty>> Specifications { get; set; } 
    }
}

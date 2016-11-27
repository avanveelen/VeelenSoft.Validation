using System;
using NUnit.Framework;
using Shouldly;
using VeelenSoft.Validation.Specifications;

namespace VeelenSoft.Validation.Tests.Specifications
{
    [TestFixture]
    [TestOf(typeof(DateNotInThePast))]
    public class DateNotInThePastTests
    {
        [Test]
        public void IsSatisfied_DateIsInThePast_ReturnsFalse()
        {
            var specification = new DateNotInThePast();
            var result = specification.IsSatisfiedBy(new DateTime(1970, 1, 1));

            result.ShouldBeFalse();
        }

        [Test]
        public void IsSatisfied_DateIsInTheFuture_ReturnsTrue()
        {
            var specification = new DateNotInThePast();
            var result = specification.IsSatisfiedBy(DateTime.Now.AddDays(1));

            result.ShouldBeTrue();
        }
    }
}
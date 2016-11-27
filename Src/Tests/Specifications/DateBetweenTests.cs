using System;
using NUnit.Framework;
using Shouldly;
using VeelenSoft.Validation.Specifications;

namespace VeelenSoft.Validation.Tests.Specifications
{
    [TestFixture]
    public class DateBetweenTests
    {
        [Test]
        public void IsSatifiedBy_WithDateBetween_ReturnsTrue()
        {
            var specification = new DateBetween(DateTime.Now.AddDays(-1), DateTime.Now.AddDays(1));
            var result = specification.IsSatisfiedBy(DateTime.Now);

            result.ShouldBeTrue();
        }

        [Test]
        public void IsSatifiedBy_WithDateOutsideLowerBoundary_ReturnsFalse()
        {
            var specification = new DateBetween(DateTime.Now.AddDays(-1), DateTime.Now.AddDays(1));
            var result = specification.IsSatisfiedBy(DateTime.Now.AddDays(-2));

            result.ShouldBeFalse();
        }

        [Test]
        public void IsSatifiedBy_WithDateOutsideUpperBoundary_ReturnsFalse()
        {
            var specification = new DateBetween(DateTime.Now.AddDays(-1), DateTime.Now.AddDays(1));
            var result = specification.IsSatisfiedBy(DateTime.Now.AddDays(+2));

            result.ShouldBeFalse();
        }
    }
}
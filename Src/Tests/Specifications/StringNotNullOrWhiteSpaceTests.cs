using NUnit.Framework;
using Shouldly;
using VeelenSoft.Validation.Specifications;

namespace VeelenSoft.Validation.Tests.Specifications
{
    [TestFixture]
    [TestOf(typeof(StringNotNullOrWhiteSpace))]
    public class StringNotNullOrWhiteSpaceTests
    {
        [TestCase("", TestName = "IsSatisfiedBy_EmptyString_ReturnsFalse")]
        [TestCase("  ", TestName = "IsSatisfiedBy_WhiteSpaceString_ReturnsFalse")]
        public void IsSatisfiedBy_ReturnsFalse(string subject)
        {
            var specification = new StringNotNullOrWhiteSpace();
            var result = specification.IsSatisfiedBy(subject);

            result.ShouldBeFalse();
        }

        [Test]
        public void IsSatisfiedBy_WithFilledString_ReturnsTrue()
        {
            var specification = new StringNotNullOrWhiteSpace();
            var result = specification.IsSatisfiedBy("hello world");

            result.ShouldBeTrue();
        }
    }
}
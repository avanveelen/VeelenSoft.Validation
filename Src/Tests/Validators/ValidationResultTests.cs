using System.Collections.Generic;
using NUnit.Framework;
using Shouldly;
using VeelenSoft.Validation.ValidationMessages;
using VeelenSoft.Validation.Validators;

namespace VeelenSoft.Validation.Tests.Validators
{
    [TestFixture]
    [TestOf(typeof(ValidationResult))]
    public class ValidationResultTests
    {
        [Test]
        public void IsValid_WithoutValidationMessages_ReturnsTrue()
        {
            var validationResult = new ValidationResult(new List<ValidationMessage>());
            validationResult.IsValid.ShouldBeTrue();
        }

        [Test]
        public void IsValid_WithValidationMessages_ReturnsFalse()
        {
            var validationResult = new ValidationResult(new List<ValidationMessage>
            {
                new ValidationMessage("error")
            });
            validationResult.IsValid.ShouldBeFalse();
        }
    }
}
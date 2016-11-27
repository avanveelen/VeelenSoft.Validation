using System;
using NUnit.Framework;
using Shouldly;
using VeelenSoft.Validation.Filters;
using VeelenSoft.Validation.Specifications;
using VeelenSoft.Validation.ValidationMessages;
using VeelenSoft.Validation.Validators;

namespace VeelenSoft.Validation.Tests.Validators
{
    [TestFixture]
    public class ValidatorTests
    {
        [Test]
        public void Test()
        {
            var validator = new ObjectValidator();
            var result = validator.Validate(new Object { Name = "test", BirthDate = new DateTime(2015,1,1)});
            result.IsValid.ShouldBeTrue();
        }

        private class ObjectValidator : Validator<Object>
        {
            public ObjectValidator()
            {
                Rule().Should(new NotBeEmpty()).WithValidationMessage("test").When(o => o.BirthDate > DateTime.Now).And(o => o.Name.Contains("test"));
                RuleFor(o => o.Name).IsNotEmpty().WithValidationMessage("test").When(o => o.Name.StartsWith("s"));
                RuleFor(o => o.BirthDate).IsNotInThePast().WithValidationMessage("date error").ExceptWhen(o => o.Name.StartsWith("t"));
            }
        }

        private class Object
        {
            public string Name { get; set; }

            public DateTime BirthDate { get; set; }
        }

        private class NotBeEmpty : IObjectSpecification<Object>
        {
            public bool IsSatisfiedBy(Object subject)
            {
                return !string.IsNullOrWhiteSpace(subject.Name);
            }

            public ValidationMessage DefaultValidationMessage { get; set; }
        }
    }
}
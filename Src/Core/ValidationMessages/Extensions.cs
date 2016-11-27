using VeelenSoft.Validation.Rules;

namespace VeelenSoft.Validation.ValidationMessages
{
    public static class Extensions
    {
        public static IRule<T> WithValidationMessage<T>(this IRule<T> rule, string message)
        {
            rule.ValidationMessage = new ValidationMessage(message);
            return rule;
        } 
    }
}
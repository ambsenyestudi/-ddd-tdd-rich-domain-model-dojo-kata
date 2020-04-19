using System;

namespace RichDomainModelKata.Domain.DomainValidation
{
    public static class StringValidationExtensions
    {
        public static void EnsureMinimumLength(this string evaluatingString, int length = 4, string argumentExceptionMessage = "string didn't meet minimum length criteria")
        {
            if (string.IsNullOrWhiteSpace(evaluatingString) || evaluatingString.Length < length)
            {
                throw new ArgumentException(argumentExceptionMessage);
            }
        }
    }
}

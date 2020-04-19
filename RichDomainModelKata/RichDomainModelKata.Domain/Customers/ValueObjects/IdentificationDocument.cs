using RichDomainModelKata.Domain.DomainValidation;
using System;

namespace RichDomainModelKata.Domain.Customers.ValueObjects
{
    public enum IdentificationType
    {
        None, IdentifactionCard, Passport, DriverLicence
    }
    public class IdentificationDocument
    {
        public string Value { get; }
        public IdentificationType Type { get; set; }
        public IdentificationDocument(string identification, IdentificationType identificationType )
        {
            identification.EnsureMinimumLength(5, "On creating identification document data was invalid ");
            Value = identification;
            EnsureIdentificationTypeNotNone(identificationType, "On creating identification document, document type was invalid");
            Type = identificationType;
        }
        public void EnsureIdentificationTypeNotNone(IdentificationType addressType, string message)
        {
            if (addressType == IdentificationType.None)
            {
                throw new ArgumentException(message);
            }
        }
    }
}

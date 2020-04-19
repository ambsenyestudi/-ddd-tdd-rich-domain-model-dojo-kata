using RichDomainModelKata.Domain.DomainValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace RichDomainModelKata.Domain.Customers.ValueObjects
{
    public enum AddressType
    {
        None, Street, Square, Circus, Alley, Avenue, Boulevard, Road, Lane
    }
    public class PostalAddress
    {
        public string Address { get; }
        public AddressType AddressType { get; }
        public string CityName { get; }
        public string StateName { get; }
        public string CountryName { get; }
        public string ZipCode { get; }

        public PostalAddress(string address, AddressType addressType, string cityName, string stateName, string countryName, string zipCode)
        {
            address.EnsureMinimumLength(3 , "On creating adrress adress data was invalid ");
            Address = address;
            EnsureAddressTypeNotNone(addressType, "On creating adrress adress none is not al valid addressType");
            AddressType = addressType;
            cityName.EnsureMinimumLength(3, "On creating adrress adress data was invalid ");
            CityName = cityName;
            stateName.EnsureMinimumLength(2, "On creating adrress adress data was invalid ");
            StateName = stateName;
            countryName.EnsureMinimumLength(2, "On creating adrress adress data was invalid ");
            CountryName = countryName;
            zipCode.EnsureMinimumLength(argumentExceptionMessage:"On creating adrress zipCode was invalid ");
            ZipCode = zipCode;
        }
        public void EnsureAddressTypeNotNone(AddressType addressType, string message)
        {
            if(addressType == AddressType.None)
            {
                throw new ArgumentException(message);
            }
        }


    }
}

using RichDomainModelKata.Domain.Customers.ValueObjects;
using System;
using System.Collections.Generic;

namespace RichDomainModelKata.Domain.Customers
{
    public class Customer
    {
        public Guid Id { get; }
        
        #region PersonalInfo
        public string FullName { get; set; }
        public IEnumerable<PostalAddress> AddressCollection { get; set; }
        public IdentificationDocument Identification{ get; set; }
        #endregion PersonalInfo
        public Customer(Guid id)
        {
            Id = id;
        }
    }
}

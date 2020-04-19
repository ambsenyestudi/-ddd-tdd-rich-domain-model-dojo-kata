using RichDomainModelKata.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RichDomainModelKata.Domain.Accounts
{
    public class Account
    {
        public Guid Id { get; }
        public Customer Owner { get; private set; }
        public Account(Guid id, Customer owner)
        {
            Id = id;
            Owner = owner;
        }

    }
}

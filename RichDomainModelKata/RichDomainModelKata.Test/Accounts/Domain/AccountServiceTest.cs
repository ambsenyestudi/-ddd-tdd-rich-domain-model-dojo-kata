using RichDomainModelKata.Domain.Accounts;
using RichDomainModelKata.Domain.Customers;
using System;
using Xunit;

namespace RichDomainModelKata.Test.Accounts.Domain
{
    public class account_service_should
    {
        public AccountService accountService;
        public Guid customerGuid;
        public account_service_should()
        {
            accountService = new AccountService();
            customerGuid = Guid.NewGuid();
        }
        [Fact]
        public void register_new_with_customer_personal_info()
        {
            var customer = new Customer(customerGuid);
            var registeredAccount = accountService.RegisterAccount(customer);
            Assert.NotNull(registeredAccount);
        }
    }
}

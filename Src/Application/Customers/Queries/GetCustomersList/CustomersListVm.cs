using System.Collections.Generic;

namespace Northwind.UseCases.Customers.Queries.GetCustomersList
{
    public class CustomersListVm
    {
        public IList<CustomerLookupDto> Customers { get; set; }
    }
}

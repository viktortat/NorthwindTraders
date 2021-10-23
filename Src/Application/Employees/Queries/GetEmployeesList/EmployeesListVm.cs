using System.Collections.Generic;

namespace Northwind.UseCases.Employees.Queries.GetEmployeesList
{
    public class EmployeesListVm
    {
        public IList<EmployeeLookupDto> Employees { get; set; }
    }
}
 
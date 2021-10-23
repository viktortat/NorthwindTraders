using FluentValidation;

namespace Northwind.UseCases.Customers.Commands.DeleteCustomer
{
    public class DeleteCustomerCommandValidator : AbstractValidator<DeleteCustomerCommand>
    {
        public DeleteCustomerCommandValidator()
        {
            RuleFor(v => v.Id).NotEmpty().Length(5);
        }
    }
}

﻿using Northwind.Persistence;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using AutoMapper;
using Northwind.UseCases.Customers.Queries.GetCustomerDetail;
using Northwind.UseCases.UnitTests.Common;

namespace Northwind.UseCases.UnitTests.Customers.Queries
{
    [Collection("QueryCollection")]
    public class GetCustomerDetailQueryHandlerTests
    { 
        private readonly NorthwindDbContext _context;
        private readonly IMapper _mapper;

        public GetCustomerDetailQueryHandlerTests(QueryTestFixture fixture)
        {
            _context = fixture.Context;
            _mapper = fixture.Mapper;
        }    

        [Fact]
        public async Task GetCustomerDetail()
        {
            var sut = new GetCustomerDetailQueryHandler(_context, _mapper);

            var result = await sut.Handle(new GetCustomerDetailQuery { Id = "JASON" }, CancellationToken.None);

            result.ShouldBeOfType<CustomerDetailVm>();
            result.Id.ShouldBe("JASON");
        }
    }
}

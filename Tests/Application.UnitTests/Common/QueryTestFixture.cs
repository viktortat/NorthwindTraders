using System;
using AutoMapper;
using Northwind.Persistence;
using Northwind.UseCases.Common.Mappings;
using Xunit;

namespace Northwind.UseCases.UnitTests.Common
{
    public class QueryTestFixture : IDisposable
    {
        public NorthwindDbContext Context { get; private set; }
        public IMapper Mapper { get; private set; }

        public QueryTestFixture()
        {
            Context = NorthwindContextFactory.Create();

            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            Mapper = configurationProvider.CreateMapper();
        }

        public void Dispose()
        {
            NorthwindContextFactory.Destroy(Context);
        }
    }

    [CollectionDefinition("QueryCollection")]
    public class QueryCollection : ICollectionFixture<QueryTestFixture> { }
}
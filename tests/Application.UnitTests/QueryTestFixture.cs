using System;
using AutoMapper;
using MediTest.Application.Common.Mappings;
using MediTest.Infrastructure.Persistence;
using Xunit;

namespace MediTest.Application.UnitTests.Common
{
    public sealed class QueryTestFixture : IDisposable
    {
        public QueryTestFixture()
        {
            Context = ApplicationDbContextFactory.Create();

            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            Mapper = configurationProvider.CreateMapper();
        }
        public ApplicationDbContext Context { get; }

        public IMapper Mapper { get; }

        public void Dispose()
        {
            ApplicationDbContextFactory.Destroy(Context);
        }
    }

    [CollectionDefinition("QueryTests")]
    public class QueryCollection : ICollectionFixture<QueryTestFixture> { }
}
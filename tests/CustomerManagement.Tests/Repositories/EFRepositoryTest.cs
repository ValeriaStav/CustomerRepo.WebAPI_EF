using CustomerManagement.BusinessEntities;
using CustomerManagement.EFRepositories;
using CustomerManagement.Interfaces;

namespace CustomerManagement.Tests.Repositories
{
    public class EFRepositoryTest
    {
        [Fact]
        public void ShouldCreateEFCustomerRepository()
        {
            var efRepository = new EFCustomerRepository();
            Assert.NotNull(efRepository);

            Assert.IsAssignableFrom<IRepository<Customer>>(efRepository);

        }

        [Fact]
        public void ShouldCreateEFAddressRepository()
        {
            var efRepository = new EFAddressRepository();
            Assert.NotNull(efRepository);

            Assert.IsAssignableFrom<IRepository<Address>>(efRepository);
        }
    }
}
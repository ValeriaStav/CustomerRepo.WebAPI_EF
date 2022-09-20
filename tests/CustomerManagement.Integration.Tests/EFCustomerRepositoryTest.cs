using CustomerManagement.BusinessEntities;
using CustomerManagement.EFRepositories;
using FluentAssertions;
using Xunit;

namespace CustomerManagement.Integration.Tests
{
    public class EFCustomerRepositoryTest
    {

        public EFCustomerRepositoryFixture Fixture => new EFCustomerRepositoryFixture();

        [Fact]
        public void ShouldBeAbleToCreateEFCustomerRepository()
        {
            var customerRepository = new EFCustomerRepository();
            Assert.NotNull(customerRepository);
        }

        [Fact]
        public void ShouldBeAbleToCreateCustomer()
        {
            var customerRepository = new EFCustomerRepository();
            var fixture = new EFCustomerRepositoryFixture();

            customerRepository.DeleteAll();
            var customer = fixture.MockCustomer();
            customerRepository.Create(customer);

            Assert.NotNull(customer);
        }

        [Fact]
        public void ShouldBeAbleToReadCustomer()
        {
            var customerRepository = new EFCustomerRepository();
            var fixture = new EFCustomerRepositoryFixture();
            var customer = fixture.MockCustomer();

            var createdCustomer = customerRepository.Read(285);

            Assert.NotNull(createdCustomer);

            Assert.Equal(customer.FirstName, createdCustomer.FirstName);
            Assert.Equal(customer.LastName, createdCustomer.LastName);  
        }

        [Fact]
        public void ShouldBeAbleToUpdateCustomer()
        {
            var customerRepository = new EFCustomerRepository();
            var fixture = new EFCustomerRepositoryFixture();
            var customer = Fixture.MockCustomer();
            customer.LastName = "Black";

            customerRepository.Update(customer);

            var createdCustomer = customerRepository.Read(310);
            Assert.NotNull(createdCustomer);

            Assert.Equal(customer.CustomerId, createdCustomer.CustomerId);
            Assert.Equal("Black", createdCustomer.LastName);
        }

        [Fact]
        public void ShouldBeAbleToDeleteCustomer()
        {
            var customerRepository = new EFCustomerRepository();
            var fixture = new EFCustomerRepositoryFixture();
            var customer = Fixture.MockCustomer();

            var createdCustomer = customerRepository.Read(307);
            Assert.NotNull(createdCustomer);

            customerRepository.Delete(307);

            var deletedCustomer = customerRepository.Read(0);
            Assert.Null(deletedCustomer);
        }

        public class EFCustomerRepositoryFixture
        {
            public Customer MockCustomer()
            {
                var customer = new Customer
                {
                    FirstName = "John",
                    LastName = "Doe",
                    CustomerPhoneNumber = "+1234567890",
                    CustomerEmail = "JohnD555@gmail.com",
                    TotalPurchaseAmount = 1000
                };

                var customerRepository = new EFCustomerRepository();
                customerRepository.Create(customer);
                return customer;
            }
        }
    }
}

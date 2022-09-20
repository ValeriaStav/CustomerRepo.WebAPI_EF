using CustomerManagement.BusinessEntities;
using CustomerManagement.Repositories;
using FluentAssertions;
using Xunit;

namespace CustomerManagement.Integration.Tests
{
    public class CustomerRepositoryTests
    {
        public CustomerRepositoryFixture Fixture => new CustomerRepositoryFixture();

        [Fact]
        public void ShouldBeAbleToCreateCustomerRepository()
        {
            var repository = new CustomerRepository();
            repository.Should().NotBeNull();
        }

        [Fact]
        public void ShouldBeAbleToCreateCustomer()
        {
            Fixture.DeleteAll();
            var repositiry = new CustomerRepository();
            var customer = new Customer
            {
                //CustomerId = 4,
                FirstName = "Vika",
                LastName = "Stavriadi",
                CustomerPhoneNumber = "0987654321",
                CustomerEmail = "edxgtdjyt@jkjk.com",
                TotalPurchaseAmount = 7000
            };

            customer.Should().NotBe(null);
        }

        [Fact]
        public void ShouldBeAbleToReadCustomer()
        {
            Fixture.DeleteAll();
            Fixture.CreateMockCustomer();
            var createdCustomer = Fixture.CreateCustomerRepository().Read(0);

            createdCustomer.Should().NotBe(null);
            createdCustomer.CustomerId.Should().Be(0);
        }

        [Fact]
        public void ShouldBeAbleToUpdateCustomer()
        {
            Fixture.DeleteAll();
            var customer = Fixture.CreateMockCustomer();
            var repository = Fixture.CreateCustomerRepository();
            customer.LastName = "Black";

            repository.Update(customer);
            customer.LastName.Should().Be("Black");
        }

        [Fact]
        public void ShouldBeAbleToDeleteCustomer()
        {
            Fixture.DeleteAll();
            Fixture.CreateMockCustomer();
            var repository = Fixture.CreateCustomerRepository();

            repository.Delete(1);
            var deletedCustomer = repository.Read(1);
            deletedCustomer.Should().Be(null);

        }

        public class CustomerRepositoryFixture
        {
            public void DeleteAll()
            {
                var repository = new CustomerRepository();
                repository.DeleteAll();
            }

            public Customer CreateMockCustomer()
            {
                var customer = new Customer
                {
                    CustomerId = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    CustomerPhoneNumber = "1234567890",
                    CustomerEmail = "JohnD555@gmail.com",
                    TotalPurchaseAmount = 10000
                };

                var customerRepository = new CustomerRepository();
                customerRepository.Create(customer);
                return customer;
            }
            public CustomerRepository CreateCustomerRepository()
            {
                return new CustomerRepository();
            }
        }
    }
}
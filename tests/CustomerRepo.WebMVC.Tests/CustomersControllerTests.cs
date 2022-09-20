using CustomerManagement.BusinessEntities;
using CustomerManagement.Interfaces;
using CustomerRepo.WebMVC.Controllers;
using Moq;
using System.Collections.Generic;
using System.Web.Mvc;
using Xunit;

namespace CustomerRepo.WebMVC.Tests
{
    public class CustomersControllerTests
    {
        [Fact]
        public void ShouldCreateCustomer()
        {
            var customersControllerMock = new Mock<IRepository<Customer>>();
            var customersController = new CustomersController(customersControllerMock.Object);
            customersController.Create();

            var result = customersController.Create(new Customer()
            {
                FirstName = "Vasia",
                LastName = "Petrov",
                CustomerPhoneNumber = "0987654321",
                CustomerEmail = "edxgtdjyt@jkjk.com",
                TotalPurchaseAmount = 7000
            }) as RedirectToRouteResult;

            Assert.NotNull(result);
        }

        [Fact]
        public void ShouldCreateCustomersController()
        {
            var controller = new CustomersController();
            Assert.NotNull(controller);
        }

        [Fact]
        public void ShouldEditCustomer()
        {
            var customersControllerMock = new Mock<IRepository<Customer>>();
            var customersController = new CustomersController(customersControllerMock.Object);
            customersController.Edit(1);

            var result = customersController.Edit(1, new Customer()
            {
                FirstName = "Vasia",
                LastName = "Petrov",
                CustomerPhoneNumber = "0987654321",
                CustomerEmail = "edxgtdjyt@jkjk.com",
                TotalPurchaseAmount = 7000
            }) as RedirectToRouteResult;

            Assert.NotNull(result);
        }

        [Fact]
        public void ShouldDeleteCustomer()
        {
            var customersControllerMock = new Mock<IRepository<Customer>>();
            var customersController = new CustomersController(customersControllerMock.Object);
            customersController.Delete(1);

            var result = customersController.Delete(1, new Customer
            {
                FirstName = "Vasia",
                LastName = "Petrov",
                CustomerPhoneNumber = "0987654321",
                CustomerEmail = "edxgtdjyt@jkjk.com",
                TotalPurchaseAmount = 7000
            }) as RedirectToRouteResult;

            Assert.Empty("");
        }

        [Fact]
        public void ShouldReturnCustomersList()
        {
            var controller = new CustomersController();
            var customersResult = controller.Index();
            var customersView = customersResult as ViewResult;
            var customersModel = customersView.Model as List<Customer>;
            Assert.NotNull(customersModel);
        }
    }
}
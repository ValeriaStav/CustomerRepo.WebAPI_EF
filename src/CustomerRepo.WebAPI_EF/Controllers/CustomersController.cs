using CustomerManagement.BusinessEntities;
using CustomerManagement.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerRepo.WebAPI_EF.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly IRepository<Customer> _customerRepository;

        public CustomersController(IRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet]
        public ActionResult<List<Customer>> GetAll()
        {
            var customers = _customerRepository.GetAll();
            
            if (customers.Count == 0)
            {
                return NotFound("NOT FOUND");
            }
            return Ok(_customerRepository.GetAll());
        }
    }
}

using CustomerManagement.BusinessEntities;
using CustomerManagement.Interfaces;
using CustomerManagement.Repositories;
using System;

namespace CustomerRepo.WebForms
{
    public partial class CustomerDelete : System.Web.UI.Page
    {
        public IRepository<Customer> _customerRepository;
        public CustomerDelete()
        {
            _customerRepository = new CustomerRepository();
        }
        public CustomerDelete(IRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public void Page_Load(object sender, EventArgs e)
        {
            var customerIdReq = Convert.ToInt32(Request.QueryString["customerId"]);
            _customerRepository.Delete(customerIdReq);
            Response.Redirect("CustomersList.aspx");
        }
    }
}
using CustomerManagement.BusinessEntities;
using CustomerManagement.Interfaces;
using CustomerManagement.Repositories;
using System;
using System.Collections.Generic;

namespace CustomerRepo.WebForms
{
    public partial class CustomersList : System.Web.UI.Page
    {
        private IRepository<Customer> _customerRepository;
        public List<Customer> Customers { get; set; }
        public CustomersList()
        {
            _customerRepository = new CustomerRepository();
        }
        public CustomersList(IRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }


        public void LoadCustomersFromDatabase()
        {
            Customers = _customerRepository.GetAll();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCustomersFromDatabase();
            if (!IsPostBack)
            {
                var customerIdReq = Convert.ToInt32(Request.QueryString["customerId"]);
                _customerRepository.Delete(customerIdReq);
            }
        }
    }
}
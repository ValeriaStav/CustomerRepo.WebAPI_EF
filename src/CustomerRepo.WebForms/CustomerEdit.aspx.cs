using CustomerManagement.BusinessEntities;
using CustomerManagement.Interfaces;
using CustomerManagement.Repositories;
using System;
using System.Web;

namespace CustomerRepo.WebForms
{
    public partial class CustomerEdit : System.Web.UI.Page
    {
        private IRepository<Customer> _customerRepository;

        public CustomerEdit()
        {
            _customerRepository = new CustomerRepository();
        }

        public CustomerEdit(IRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var customerIdReq = Convert.ToInt32(Request.QueryString["customerId"]);
                if (customerIdReq != 0)
                {
                    var customer = _customerRepository.Read(customerIdReq);
                    firstName.Text = customer.FirstName;
                    lastName.Text = customer.LastName;
                    customerPhoneNumber.Text = customer.CustomerPhoneNumber;
                    customerEmail.Text = customer.CustomerEmail;
                    totalPurchaseAmount.Text = customer.TotalPurchaseAmount.ToString();
                }
            }
        }

        public void OnClickSave(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                CustomerId = Convert.ToInt32(Request.QueryString["customerId"]),
                FirstName = firstName?.Text,
                LastName = lastName.Text,
                CustomerPhoneNumber = customerPhoneNumber.Text,
                CustomerEmail = customerEmail.Text,
                TotalPurchaseAmount = Convert.ToInt32(totalPurchaseAmount.Text)
            };

            if (Convert.ToInt32(Request.QueryString["customerId"]) == 0)
            {
                _customerRepository.Create(customer);
            }
            else
            {
                _customerRepository.Update(customer);
            }
            HttpContext.Current.Response.Redirect("CustomersList.aspx");
        }
    }
}